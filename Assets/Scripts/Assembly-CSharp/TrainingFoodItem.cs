using UnityEngine;

public class TrainingFoodItem : MonoBehaviour
{
	[SerializeField]
	private UITexture m_txItemPic;

	[SerializeField]
	private UILabel m_sNeedNum;

	[SerializeField]
	private UILabel m_sLackMark;

	[SerializeField]
	private GameObject m_goLockMark;

	[SerializeField]
	private UIButton m_sSelectButton;

	[SerializeField]
	private UILabel m_sQualityNum;

	[SerializeField]
	private GameObject m_goSetOKMark;

	private int m_iNO;

	public int NO
	{
		get
		{
			return 0;
		}
	}

	public void Init(int no, int quality, int have, MasterItem master, bool disable = false)
	{
	}

	private void SetNeedNum(int need, int have)
	{
	}
}
