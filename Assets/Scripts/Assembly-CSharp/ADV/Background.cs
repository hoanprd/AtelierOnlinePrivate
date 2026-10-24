using System.Collections;
using System.Diagnostics;
using UnityEngine;

namespace ADV
{
    public class Background : MonoBehaviour
    {
        public UITexture m_txPicture;

        public UILabel m_sPlaceName;

        public UILabel m_sPlaceName2;

        public UITweenReset m_sAnim;

        public UITweenReset m_sShakeAnim;

        private float m_fShakeTime;

        private int m_iShakeCount;

        public bool IsAnimEnd
        {
            get
            {
                bool flag = m_sAnim == null || m_sAnim.IsAnimEnd;
                if (flag && m_sShakeAnim != null)
                {
                    flag = m_sShakeAnim.IsAnimEnd;
                }
                return flag;
            }
        }

        public static string GetImagePath(int picID)
        {
            // Sử dụng định dạng đường dẫn tài nguyên hình nền ADV tiêu chuẩn
            return "Background/" + picID;
        }

        public void Init()
        {
            if (m_txPicture != null)
            {
                m_txPicture.mainTexture = null;
            }
            SetName(string.Empty, string.Empty);
            gameObject.SetActive(false);
        }

        public void SetPicture(int picID)
        {
            string path = GetImagePath(picID);
            UIAssetBundleTexture.Regist(path, m_txPicture, true);
        }

        public void SetShake(float time, int count)
        {
            StopAllCoroutines();
            m_fShakeTime = time;
            m_iShakeCount = count;
            StartCoroutine(ShakePicture());

            if (m_sShakeAnim != null)
            {
                m_sShakeAnim.ResetTweenForward();
            }
        }

        public void StopShake()
        {
            StopAllCoroutines();
            if (m_sShakeAnim != null)
            {
                UITweener[] tweener = m_sShakeAnim.GetComponentsInChildren<UITweener>();
                for (int i = 0; i < tweener.Length; i++)
                {
                    tweener[i].Sample(1f, true);
                    tweener[i].enabled = false;
                }
            }
        }

        public void SetName(string main, string sub = "")
        {
            if (m_sPlaceName != null)
            {
                m_sPlaceName.text = main;
                m_sPlaceName.gameObject.SetActive(!string.IsNullOrEmpty(main));
            }

            if (m_sPlaceName2 != null)
            {
                m_sPlaceName2.text = sub;
                m_sPlaceName2.gameObject.SetActive(!string.IsNullOrEmpty(sub));
            }
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
                EventDelegate ed = new EventDelegate(this, "OnCloseEnd");
                m_sAnim.SetOnFinish(ed);
                m_sAnim.TweenReverse();
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
                UITweener[] tweener = m_sAnim.GetComponentsInChildren<UITweener>();
                for (int i = 0; i < tweener.Length; i++)
                {
                    tweener[i].Sample(1f, true);
                    tweener[i].enabled = false;
                }
            }
        }

        private void OnCloseEnd()
        {
            gameObject.SetActive(false);
        }

        [DebuggerHidden]
        private IEnumerator ShakePicture()
        {
            float elapsed = 0f;
            Vector3 originalPos = m_txPicture != null ? m_txPicture.transform.localPosition : Vector3.zero;

            while (m_fShakeTime <= 0f || elapsed < m_fShakeTime)
            {
                float x = Random.Range(-5f, 5f);
                float y = Random.Range(-5f, 5f);

                if (m_txPicture != null)
                {
                    m_txPicture.transform.localPosition = originalPos + new Vector3(x, y, 0f);
                }

                elapsed += Time.deltaTime;
                yield return null;
            }

            if (m_txPicture != null)
            {
                m_txPicture.transform.localPosition = originalPos;
            }
        }
    }
}