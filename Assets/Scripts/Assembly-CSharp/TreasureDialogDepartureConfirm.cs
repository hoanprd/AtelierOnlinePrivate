using UnityEngine;

public class TreasureDialogDepartureConfirm : MonoBehaviour
{
	[SerializeField]
	private UITweenReset m_sAnim;

	[SerializeField]
	private TreasureDialogImmidiate m_sImmidiate;

	[SerializeField]
	private UITexture m_txIcon;

	[SerializeField]
	private UILabel m_sCost;

	[SerializeField]
	private UILabel m_sHave;

	private HuntInfo m_sinfo;

	private TreasureDialog.ConfirmResult m_sOnResult;

	private GameObject m_goCollision;

	public void Init(HuntInfo info, TreasureDialog.ConfirmResult onResult)
	{
	}

	public void OnDecide()
	{
	}

	public void OnCancel()
	{
	}

	public void OnImmidiate()
	{
	}

	private void OnNext()
	{
	}

	private void OnImmidiateResult(bool decide, eHuntReturnType result, int wealthKind)
	{
	}

	private void OnDisable()
	{
	}

	private void OnCloseEnd()
	{
	}
}
