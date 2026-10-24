using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using UnityEngine;

[RequireComponent(typeof(UILabel))]
[AddComponentMenu("NGUI/Interaction/Typewriter Effect")]
public class TypewriterEffect : MonoBehaviour
{
    [StructLayout((LayoutKind)0, Size = 24)]
    private struct FadeEntry
    {
        public int index;

        public string text;

        public float alpha;
    }

    public static TypewriterEffect current;

    public int charsPerSecond = 20;

    public float fadeInTime = 0f;

    public float delayOnPeriod = 0f;

    public float delayOnNewLine = 0f;

    public UIScrollView scrollView;

    public bool keepFullDimensions = false;

    public List<EventDelegate> onFinished = new List<EventDelegate>();

    private UILabel mLabel;

    private string mFullText;

    private int mCurrentOffset;

    private float mNextChar;

    private bool mReset = true;

    private bool mActive;

    private BetterList<FadeEntry> mFade = new BetterList<FadeEntry>();

    public bool isActive
    {
        get
        {
            return mActive;
        }
    }

    public void ResetToBeginning()
    {
        mReset = true;
        mActive = true;
        mCurrentOffset = 0;
        mNextChar = 0f;
        mFade.Clear();
        Update();
    }

    public void Finish()
    {
        if (mActive)
        {
            mActive = false;
            if (mLabel != null && !string.IsNullOrEmpty(mFullText))
            {
                mCurrentOffset = mFullText.Length;
                mLabel.text = mFullText;
            }
            mFade.Clear();
            current = this;
            EventDelegate.Execute(onFinished);
            current = null;
        }
    }

    private void OnEnable()
    {
        ResetToBeginning();
    }

    private void OnDisable()
    {
        mActive = false;
    }

    private void Update()
    {
        if (!mActive) return;

        if (mLabel == null)
        {
            mLabel = GetComponent<UILabel>();
            if (mLabel == null)
            {
                mActive = false;
                return;
            }
        }

        if (mReset)
        {
            mReset = false;
            mCurrentOffset = 0;
            mNextChar = 0f;
            mFullText = mLabel.text;
            mFade.Clear();
        }

        if (string.IsNullOrEmpty(mFullText) || mCurrentOffset >= mFullText.Length)
        {
            mActive = false;
            current = this;
            EventDelegate.Execute(onFinished);
            current = null;
            return;
        }

        while (mActive && mNextChar <= Time.realtimeSinceStartup)
        {
            if (charsPerSecond <= 0)
            {
                mCurrentOffset = mFullText.Length;
                mNextChar = Time.realtimeSinceStartup;
            }
            else
            {
                int chars = mCurrentOffset;
                DecodeAlpha(ref chars, mFullText.Length);
                mCurrentOffset = chars;

                if (mCurrentOffset >= mFullText.Length)
                {
                    mActive = false;
                    break;
                }

                char c = mFullText[mCurrentOffset];
                mCurrentOffset++;

                float delay = 1f / Mathf.Max(1f, charsPerSecond);

                if (c == '.' || c == '?' || c == '!')
                {
                    delay += delayOnPeriod;
                }
                else if (c == '\n')
                {
                    delay += delayOnNewLine;
                }

                if (fadeInTime > 0f)
                {
                    FadeEntry fe = new FadeEntry();
                    fe.index = mCurrentOffset - 1;
                    fe.text = mFullText.Substring(fe.index, 1);
                    fe.alpha = 0f;
                    mFade.Add(fe);
                }

                mNextChar += delay;
                if (mNextChar < Time.realtimeSinceStartup)
                {
                    mNextChar = Time.realtimeSinceStartup;
                }
            }

            UpdateText();

            if (scrollView != null)
            {
                scrollView.UpdatePosition();
            }
        }

        if (fadeInTime > 0f && mFade.size > 0)
        {
            float delta = Time.deltaTime;

            for (int i = mFade.size; i > 0;)
            {
                int index = --i;
                FadeEntry fe = mFade.buffer[index];
                fe.alpha += delta / fadeInTime;

                if (fe.alpha >= 1f)
                {
                    mFade.RemoveAt(index);
                }
                else
                {
                    mFade.buffer[index] = fe;
                }
            }

            UpdateText();
        }
    }

    private void DecodeAlpha(ref int index, int textLength)
    {
        if (index < textLength && mFullText[index] == '[')
        {
            if (index + 2 < textLength && mFullText[index + 2] == ']')
            {
                index += 3;
                DecodeAlpha(ref index, textLength);
            }
            else if (index + 8 < textLength && mFullText[index + 8] == ']')
            {
                index += 9;
                DecodeAlpha(ref index, textLength);
            }
        }
    }

    private void UpdateText()
    {
        if (mLabel == null) return;

        if (keepFullDimensions)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(mFullText.Substring(0, mCurrentOffset));

            for (int i = mCurrentOffset; i < mFullText.Length; i++)
            {
                char c = mFullText[i];
                if (c == '\n')
                {
                    sb.Append('\n');
                }
                else
                {
                    sb.Append(' ');
                }
            }
            mLabel.text = sb.ToString();
        }
        else
        {
            mLabel.text = mFullText.Substring(0, mCurrentOffset);
        }
    }
}