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
		}

		public void SetArrow(Data data)
		{
		}

		public bool IsStillActive()
		{
			return false;
		}

		private void OnDisable()
		{
		}
	}
}
