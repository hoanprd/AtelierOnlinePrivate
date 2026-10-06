using UnityEngine;

namespace ADV
{
	public class EmoticonMark : MonoBehaviour
	{
		[SerializeField]
		private GameObject m_goPrefab;

		[SerializeField]
		private Transform[] m_atrRoot;

		private Emoticon m_sEmoticon;

		private EEmoticon m_eKind;

		private int m_iPosIndex;

		public bool IsAnimEnd
		{
			get
			{
				return false;
			}
		}

		public bool IsDisp
		{
			get
			{
				return false;
			}
		}

		public void Init()
		{
		}

		public void Play(EEmoticon kind, int posIndex = -1)
		{
		}
	}
}
