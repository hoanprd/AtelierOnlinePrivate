using Tutorial;
using UnityEngine;

namespace ADV
{
    public class UIManager : MonoBehaviour
    {
        public LogWindow m_sLog;

        public SkipButton m_sSkipButton;

        public TalkWindow m_sTalk;

        public SelectList m_sSelect;

        public BlackFilter m_sBlackFilter;

        public BlackFilter m_sBlackBackground;

        public PictureWindow m_sPicture;

        public Background m_sBG;

        public TutorialCommandArrow m_sTutorialArrow;

        public EmoticonMark m_sEmoticon;

        public GameObject m_goSepia;

        public ItemPicWindow m_sItemPicWindow;

        public UITexture m_txStill;

        public GameObject m_goOverHeadRoot;

        public void Init()
        {
            // 1. Khởi tạo Log Window[cite: 5]
            if (m_sLog != null)
            {
                m_sLog.Init();
                if (m_sLog.gameObject != null)
                {
                    m_sLog.gameObject.SetActive(false);
                }
            }

            // 2. Khởi tạo Talk Window[cite: 5]
            if (m_sTalk != null)
            {
                m_sTalk.Init();
            }

            // 3. Khởi tạo Select List[cite: 5]
            if (m_sSelect != null)
            {
                m_sSelect.Init();
            }

            // 4. Khởi tạo Skip Button[cite: 5]
            if (m_sSkipButton != null)
            {
                m_sSkipButton.Init();
            }

            // 5. Black Filter & Black Background (Mặc định ẩn)[cite: 5]
            if (m_sBlackFilter != null && m_sBlackFilter.gameObject != null)
            {
                m_sBlackFilter.gameObject.SetActive(false);
            }

            if (m_sBlackBackground != null && m_sBlackBackground.gameObject != null)
            {
                m_sBlackBackground.gameObject.SetActive(false);
            }

            // 6. Khởi tạo Picture Window[cite: 5]
            if (m_sPicture != null)
            {
                m_sPicture.Init();
            }

            // 7. Khởi tạo Background[cite: 5]
            if (m_sBG != null)
            {
                m_sBG.Init();
            }

            // 8. Khởi tạo Emoticon Mark[cite: 5]
            if (m_sEmoticon != null)
            {
                m_sEmoticon.Init();
            }

            // 9. Sepia (Mặc định ẩn)[cite: 5]
            if (m_goSepia != null)
            {
                m_goSepia.SetActive(false);
            }

            // 10. Item Pic Window (Mặc định ẩn)[cite: 5]
            if (m_sItemPicWindow != null && m_sItemPicWindow.gameObject != null)
            {
                m_sItemPicWindow.gameObject.SetActive(false);
            }

            // 11. Still Texture (CG) container cha (Mặc định ẩn)[cite: 5]
            if (m_txStill != null)
            {
                Transform parentTransform = m_txStill.transform.parent;
                if (parentTransform != null)
                {
                    GameObject parentObj = parentTransform.gameObject;
                    if (parentObj != null)
                    {
                        parentObj.SetActive(false);
                    }
                }
            }
        }

        public void SetArrow(Data data)
        {
            // Xử lý nạp Tutorial Arrow động theo đúng phương thức Exec của TutorialCommandBase
            if (m_sTutorialArrow == null)
            {
                m_sTutorialArrow = NGUITools.AddMissingComponent<TutorialCommandArrow>(gameObject);
            }
            m_sTutorialArrow.Exec(data);
        }

        public bool IsStillActive()
        {
            // Kiểm tra trạng thái hiển thị của Still Texture[cite: 5]
            if (m_txStill != null)
            {
                return m_txStill.gameObject.activeInHierarchy;
            }
            return false;
        }

        private void OnDisable()
        {
            // Dọn dẹp Tutorial Arrow khi disable UIManager[cite: 5]
            if (m_sTutorialArrow != null)
            {
                Destroy(m_sTutorialArrow);
            }
        }
    }
}