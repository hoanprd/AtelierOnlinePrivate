using System.Collections.Generic;
using UnityEngine;

public class TreasureDialogImmidiate : MonoBehaviour
{
	[SerializeField]
	private UITweenReset m_sAnim;

	[SerializeField]
	private UILabel m_sRemainTime;

	[SerializeField]
	private List<TreasureDialogPriceItem> m_vPrice;

	[SerializeField]
	private UIGrid m_sPriceGrid;

	[SerializeField]
	private UILabel m_sWealthCompensation;

	[SerializeField]
	private UILabel m_sWealthFree;

	[SerializeField]
	private TreasureDialogPaymentConfirm m_sConfirm;

	private TreasureDialog.ConfirmResult m_sOnResult;

	private HuntInfo m_sInfo;

	private bool m_bClose;

	private GameObject m_goCollision;

	private TreasureDialogPriceItem m_sSelectWealth;

	public void Init(HuntInfo info, TreasureDialog.ConfirmResult onResult, bool close)
	{
	}

	public void OnSelectWealth(TreasureDialogPriceItem target)
	{
	}

	private void DispSelectWealth()
	{
	}

	public void OnCancel()
	{
	}

	private void OnCloseEnd()
	{
	}
}
