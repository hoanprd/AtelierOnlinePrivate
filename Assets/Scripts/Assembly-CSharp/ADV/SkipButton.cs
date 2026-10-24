using System.Collections;
using System.Diagnostics;
using UnityEngine;

namespace ADV
{
    public class SkipButton : MonoBehaviour
    {
        public UIButton m_sButton;

        public UITweenReset m_sAnim;

        private bool m_bSkip;

        private bool m_bEnable;

        private bool m_bFade;

        private bool m_bDialog;

        private bool m_bButtonActive;

        public bool IsSkip
        {
            get
            {
                return m_bSkip;
            }
            set
            {
                SetSkip(value);
            }
        }

        public bool IsDialog
        {
            get
            {
                return m_bDialog;
            }
        }

        public bool IsActive
        {
            get
            {
                return m_bButtonActive;
            }
        }

        public void Init()
        {
            m_bEnable = true;
            SetEnable(false);
            if (gameObject != null)
            {
                m_bButtonActive = gameObject.activeInHierarchy;
            }
        }

        public void Bringin()
        {
            m_bEnable = true;
            if (!m_bButtonActive)
            {
                if (m_bEnable)
                {
                    gameObject.SetActive(true);
                    if (m_sButton != null)
                    {
                        m_sButton.isEnabled = true;
                    }
                    SetSkip(false);
                    if (m_sAnim != null)
                    {
                        m_sAnim.ResetOnFinish();
                        m_sAnim.ResetTweenForward();
                    }
                    m_bButtonActive = true;
                }
            }
        }

        public void Dismiss()
        {
            if (m_bButtonActive && m_bEnable)
            {
                if (m_sButton != null)
                {
                    m_sButton.isEnabled = false;
                }
                if (m_sAnim != null)
                {
                    EventDelegate ed = new EventDelegate(this, "OnDismissEnd");
                    m_sAnim.SetOnFinish(ed);
                    m_sAnim.ResetTweenReverse();
                }
                else
                {
                    OnDismissEnd();
                }
                m_bButtonActive = false;
            }
        }

        private void OnDismissEnd()
        {
            gameObject.SetActive(false);
            m_bButtonActive = false;
        }

        public void SetEnable(bool enable)
        {
            m_bEnable = enable;
            if (!enable)
            {
                gameObject.SetActive(false);
                m_bButtonActive = false;
            }
        }

        public void SetSkip(bool skip)
        {
            m_bSkip = skip;
            StopAllCoroutines();
            System.Collections.IEnumerator routine = skip ? ChangeSkipOn() : ChangeSkipOff();
            StartCoroutine(routine);
        }

        public void OnSkip()
        {
            if (m_bFade)
            {
                return;
            }
            if (m_bSkip)
            {
                SetSkip(false);
                return;
            }
            m_bDialog = true;
            DialogCommon.CreateYesNODialog("Xác nhận", delegate (EButtonKind result)
            {
                m_bDialog = false;
                if (result == EButtonKind.eDECIDE)
                {
                    SetSkip(true);
                }
            });
        }

        [DebuggerHidden]
        private IEnumerator ChangeSkipOn()
        {
            m_bFade = true;
            yield return null;
            m_bFade = false;
        }

        [DebuggerHidden]
        private IEnumerator ChangeSkipOff()
        {
            m_bFade = true;
            yield return null;
            m_bFade = false;
        }
    }
}