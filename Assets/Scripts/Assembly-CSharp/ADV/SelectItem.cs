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
				return 0;
			}
		}

		public void Init(int id, string content)
		{
		}

		public void Bringin(float delay)
		{
		}

		public void Dismiss()
		{
		}
	}
}
