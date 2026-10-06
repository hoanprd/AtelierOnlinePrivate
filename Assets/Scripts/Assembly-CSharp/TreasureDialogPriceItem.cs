using UnityEngine;

public class TreasureDialogPriceItem : MonoBehaviour
{
	[SerializeField]
	private UILabel m_sName;

	[SerializeField]
	private UILabel m_sNum;

	[SerializeField]
	private UILabel m_sHave;

	[SerializeField]
	private UITexture m_txIcon;

	[SerializeField]
	private UIButton m_sButton;

	private int m_iWealthKind;

	public int WealthKind
	{
		get
		{
			return 0;
		}
	}

	public void Init(int remainSec, DfCntInfo price)
	{
	}
}
