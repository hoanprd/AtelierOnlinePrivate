using UnityEngine;

namespace ADV
{
    public class LogWindow : MonoBehaviour
    {
        public UIButton m_sOpenButton;

        public UIButton m_sCloseButton;

        public UIScrollBar m_sScroll;

        public UIScrollView m_sScrollView;

        public UIPanel m_sPanel;

        public GameObject m_goButtonRoot;

        public GameObject m_goListObject;

        public UILabel m_sContent;

        public Color32 m_sNameColor = new Color32(255, 220, 150, 255);

        public Color32 m_sLineColor = new Color32(200, 200, 200, 255);

        private string m_sLogText = "";

        public bool IsDisp
        {
            get
            {
                return m_goListObject != null && m_goListObject.activeSelf;
            }
        }

        public bool ButtonActive
        {
            get
            {
                return m_goButtonRoot != null && m_goButtonRoot.activeSelf;
            }
            set
            {
                if (m_goButtonRoot != null)
                {
                    m_goButtonRoot.SetActive(value);
                }
            }
        }

        private void UpdateScrollPosition()
        {
            if (m_sScrollView != null)
            {
                m_sScrollView.UpdatePosition();
                m_sScrollView.ResetPosition();
            }
        }

        public void Init()
        {
            m_sLogText = "";
            if (m_sContent != null)
            {
                m_sContent.text = "";
            }
            if (m_goListObject != null)
            {
                m_goListObject.SetActive(false);
            }
            ButtonActive = true;
        }

        public void AddContent(string name, string content)
        {
            string coloredName = GetColorText(name, m_sNameColor);
            string lineContent = string.IsNullOrEmpty(name) ? content : $"{coloredName}\n{content}\n";

            if (!string.IsNullOrEmpty(m_sLogText))
            {
                m_sLogText += "\n";
            }
            m_sLogText += lineContent;

            if (m_sContent != null)
            {
                m_sContent.text = m_sLogText;
            }

            UpdateScrollPosition();
        }

        public void AddContent(string content)
        {
            AddContent(string.Empty, content);
        }

        public void OnOpen()
        {
            if (m_goListObject != null)
            {
                m_goListObject.SetActive(true);
            }
            UpdateScrollPosition();

            var soundManager = Sound_Manager.GetInst();
            if (soundManager != null)
            {
                soundManager.PlaySound("0x62");
            }
        }

        public void OnClose()
        {
            if (m_goListObject != null)
            {
                m_goListObject.SetActive(false);
            }

            var soundManager = Sound_Manager.GetInst();
            if (soundManager != null)
            {
                soundManager.PlaySound("0x5f");
            }
        }

        private string GetColorText(string original, Color32 color)
        {
            if (string.IsNullOrEmpty(original)) return string.Empty;
            string hex = NGUIText.EncodeColor(new Color(color.r / 255f, color.g / 255f, color.b / 255f, color.a / 255f));
            return $"[{hex}]{original}[-]";
        }
    }
}