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
				return 0;
			}
		}

		public bool IsTextMove
		{
			get
			{
				return false;
			}
		}

		public bool IsBringin
		{
			get
			{
				return false;
			}
		}

		public bool IsActive
		{
			get
			{
				return false;
			}
		}

		public bool IsAnimEnd
		{
			get
			{
				return false;
			}
		}

		public bool IsHide
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public void Init()
		{
		}

		public void SetPos(int index)
		{
		}

		public void SetAlign(EPosition align)
		{
		}

		public void SetEmotion(EEmoticon emo)
		{
		}

		public void SetEmotion(int charaID, EFeel feel)
		{
		}

		public void SetEmotion(EFeel emo)
		{
		}

		public void Init(string name, int charaID = 0, EFeel feel = EFeel.eDEFAULT, EPosition pos = EPosition.eLEFT)
		{
		}

		public void SetContent(string content, bool end)
		{
		}

		public void SetContentSkip()
		{
		}

		public void Bringin()
		{
		}

		public void SetFinish()
		{
		}

		public void Dismiss()
		{
		}

		public void Tap()
		{
		}

		public void OnHide()
		{
		}
	}
}
