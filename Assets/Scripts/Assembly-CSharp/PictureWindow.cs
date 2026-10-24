using UnityEngine;

namespace ADV
{
    public class PictureWindow : MonoBehaviour
    {
        [SerializeField]
        private UITexture m_txPicture;

        [SerializeField]
        private UITweenReset m_sAnim;

        public void Init()
        {
            if (gameObject != null)
            {
                gameObject.SetActive(false);
            }
        }

        public void Init(string path)
        {
            if (gameObject != null)
            {
                gameObject.SetActive(true);
            }

            if (m_txPicture != null)
            {
                UIAssetBundleTexture.Regist(path, m_txPicture, true);
            }

            if (m_sAnim != null)
            {
                m_sAnim.ResetOnFinish();
                m_sAnim.ResetTweenForward();
            }
        }

        public void Out()
        {
            if (m_sAnim != null)
            {
                EventDelegate ed = new EventDelegate(this, "OnCloseEnd");
                m_sAnim.SetOnFinish(ed);
                m_sAnim.ResetTweenReverse();
            }
            else
            {
                OnCloseEnd();
            }
        }

        public void SetFinish()
        {
            if (m_sAnim != null)
            {
                m_sAnim.SetFinish(true);
            }
        }

        private void OnCloseEnd()
        {
            if (gameObject != null)
            {
                gameObject.SetActive(false);
            }
        }

        public bool IsAnimEnd()
        {
            if (m_sAnim != null)
            {
                return m_sAnim.IsAnimEnd;
            }
            return true;
        }
    }
}