using UnityEngine;

namespace ADV
{
    public class SelectItem : MonoBehaviour
    {
        public UILabel m_sContent;

        public UITweenReset m_sAnim;

        public UIButton m_sButton;

        private int m_iID;

        public int ID
        {
            get
            {
                return m_iID;
            }
        }

        public void Init(int id, string content)
        {
            m_iID = id;
            if (m_sContent != null)
            {
                m_sContent.text = content;
            }
            gameObject.SetActive(true);
            if (m_sButton != null)
            {
                m_sButton.enabled = true;
            }
        }

        public void Bringin(float delay)
        {
            gameObject.SetActive(true);
            if (m_sAnim != null)
            {
                m_sAnim.enabled = true;
            }
        }

        public void Dismiss()
        {
            if (m_sButton != null)
            {
                m_sButton.enabled = false;
            }
            gameObject.SetActive(false);
        }
    }
}