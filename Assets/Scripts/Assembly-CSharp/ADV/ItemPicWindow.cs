using UnityEngine;

namespace ADV
{
    public class ItemPicWindow : MonoBehaviour
    {
        [SerializeField]
        private UITweenReset m_sAnim;

        [SerializeField]
        private UITexture m_txItemPic;

        public void Init(int itemID)
        {
            string path = UIDefine.GetADVItemPicturePath(itemID);
            UIAssetBundleTexture.Regist(path, m_txItemPic, true);
        }

        public void Bringin()
        {
            gameObject.SetActive(true);
            if (m_sAnim != null)
            {
                m_sAnim.ResetOnFinish();
                m_sAnim.ResetTweenForward();
            }
        }

        public void Dismiss()
        {
            if (m_sAnim != null)
            {
                EventDelegate ed = new EventDelegate(this, "OnClose");
                m_sAnim.SetOnFinish(ed);
                m_sAnim.TweenReverse();
            }
            else
            {
                OnClose();
            }
        }

        private void OnClose()
        {
            gameObject.SetActive(false);
        }

        public bool IsPlay()
        {
            if (m_sAnim != null)
            {
                return m_sAnim.enabled;
            }
            return false;
        }

        public void Skip()
        {
            if (m_sAnim != null)
            {
                UITweener[] tweener = m_sAnim.GetComponentsInChildren<UITweener>();
                for (int i = 0; i < tweener.Length; i++)
                {
                    tweener[i].Sample(1f, true);
                    tweener[i].enabled = false;
                }
            }
        }
    }
}