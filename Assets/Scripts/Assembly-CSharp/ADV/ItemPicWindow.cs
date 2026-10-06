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
		}

		public void Bringin()
		{
		}

		public void Dismiss()
		{
		}

		private void OnClose()
		{
		}

		public bool IsPlay()
		{
			return false;
		}

		public void Skip()
		{
		}
	}
}
