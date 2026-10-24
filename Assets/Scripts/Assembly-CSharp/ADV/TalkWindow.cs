using UnityEngine;

namespace ADV
{
    public class TalkWindow : MonoBehaviour
    {
        public Transform[] m_atrEmoticonRoot;
        public Transform[] m_atrRoot;
        public Transform[] m_atrWidRoot;
        public GameObject m_goWindow;
        public GameObject[] m_agoNameRoot;
        public UILabel[] m_asName;
        public UILabel m_sContent;
        public TypewriterEffect m_sTypewriter;
        public UITexture m_txFaceIcon;
        public GameObject m_goNextIcon;
        public UITweenReset m_sAnim;
        public UITweener m_sTapAnim;

        private bool m_bBringin;
        private EPosition m_eAlign;
        private int m_iCharaID;
        private EFeel m_eFeel;
        private bool m_hide;

        public int CharaID
        {
            get
            {
                return m_iCharaID;
            }
        }

        public bool IsTextMove
        {
            get
            {
                return m_sTypewriter != null && m_sTypewriter.isActiveAndEnabled;
            }
        }

        public bool IsBringin
        {
            get
            {
                return m_bBringin;
            }
        }

        public bool IsActive
        {
            get
            {
                return gameObject.activeSelf;
            }
        }

        public bool IsAnimEnd
        {
            get
            {
                if (m_sAnim != null)
                {
                    return m_sAnim.IsAnimEnd;
                }
                return true;
            }
        }

        public bool IsHide
        {
            get
            {
                return m_hide;
            }
            set
            {
                m_hide = value;
            }
        }

        public void Init()
        {
            m_eAlign = EPosition.eLEFT;
            SetPos(0);
            SetAlign(m_eAlign);
            m_hide = false;
            gameObject.SetActive(false);
        }

        public void SetPos(int index)
        {
            // Định vị tọa độ khung thoại theo index
        }

        public void SetAlign(EPosition align)
        {
            m_eAlign = align;
        }

        public void SetEmotion(EEmoticon emo)
        {
        }

        public void SetEmotion(int charaID, EFeel feel)
        {
            m_iCharaID = charaID;
            m_eFeel = feel;
        }

        public void SetEmotion(EFeel emo)
        {
            m_eFeel = emo;
        }

        public void Init(string name, int charaID = 0, EFeel feel = EFeel.eDEFAULT, EPosition pos = EPosition.eLEFT)
        {
            if (m_asName != null)
            {
                foreach (var label in m_asName)
                {
                    if (label != null) label.text = name;
                }
            }

            if (charaID < 1)
            {
                if (m_txFaceIcon != null && m_txFaceIcon.transform.parent != null)
                {
                    m_txFaceIcon.transform.parent.gameObject.SetActive(false);
                }
            }
            else
            {
                if (m_txFaceIcon != null && m_txFaceIcon.transform.parent != null)
                {
                    m_txFaceIcon.transform.parent.gameObject.SetActive(true);
                }
                m_iCharaID = charaID;
                m_eFeel = feel;
            }
            SetAlign(pos);
            if (m_goNextIcon != null)
            {
                m_goNextIcon.SetActive(false);
            }
        }

        public void SetContent(string content, bool end)
        {
            if (m_sContent != null)
            {
                m_sContent.text = content;
            }
            if (m_sTypewriter != null)
            {
                if (end)
                {
                    m_sTypewriter.Finish();
                }
                else
                {
                    m_sTypewriter.ResetToBeginning();
                }
            }
            if (m_goNextIcon != null)
            {
                m_goNextIcon.SetActive(end);
            }
        }

        public void SetContentSkip()
        {
            if (m_sTypewriter != null)
            {
                m_sTypewriter.Finish();
            }
        }

        public void Bringin()
        {
            gameObject.SetActive(true);
            if (!m_bBringin)
            {
                if (m_sAnim != null)
                {
                    m_sAnim.ResetTweenForward();
                }
                m_bBringin = true;

                var soundManager = Sound_Manager.GetInst();
                if (soundManager != null)
                {
                    soundManager.PlaySound("0x62");
                }
            }
        }

        public void SetFinish()
        {
            if (m_sAnim != null)
            {
                if (m_bBringin)
                {
                    m_sAnim.SetFinish();
                }
                else
                {
                    m_sAnim.SetStart();
                }
            }
        }

        public void Dismiss()
        {
            if (m_bBringin)
            {
                if (m_sAnim != null)
                {
                    m_sAnim.ResetTweenReverse();
                }
                m_bBringin = false;

                var soundManager = Sound_Manager.GetInst();
                if (soundManager != null)
                {
                    soundManager.PlaySound("0x5f");
                }
            }
        }

        public void Tap()
        {
            if (m_sTypewriter != null)
            {
                m_sTypewriter.Finish();
            }
            if (m_sTapAnim != null)
            {
                m_sTapAnim.ResetToBeginning();
                m_sTapAnim.PlayForward();
            }
            if (m_goNextIcon != null)
            {
                m_goNextIcon.SetActive(true);
            }
        }

        public void OnHide()
        {
            var advManager = ADVManager.Instance;
            if (advManager != null)
            {
                advManager.HideWindow();
            }
            m_hide = true;
        }
    }
}