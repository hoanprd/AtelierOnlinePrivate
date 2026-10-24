using UnityEngine;

namespace ADV
{
    public class BlackFilter : MonoBehaviour
    {
        [SerializeField]
        private UITweenReset m_sAnim;

        private int m_iDispRequest;

        public void Init()
        {
            m_iDispRequest = 0;
            if (gameObject != null)
            {
                gameObject.SetActive(false);
            }
        }

        public void Enable(bool sw)
        {
            if (sw)
            {
                m_iDispRequest++;
                if (gameObject != null)
                {
                    gameObject.SetActive(true);
                }
                if (m_sAnim != null)
                {
                    m_sAnim.ResetOnFinish();
                    m_sAnim.TweenForward();
                }
            }
            else
            {
                if (gameObject != null && !gameObject.activeSelf)
                {
                    return;
                }
                m_iDispRequest--;
                if (m_iDispRequest > 0)
                {
                    return;
                }
                if (m_sAnim != null)
                {
                    EventDelegate ed = new EventDelegate(this, "OnAnimEnd");
                    m_sAnim.SetOnFinish(ed);
                    m_sAnim.TweenReverse();
                }
                else
                {
                    OnAnimEnd();
                }
            }
        }

        private void OnAnimEnd()
        {
            if (gameObject != null)
            {
                gameObject.SetActive(false);
            }
        }
    }
}