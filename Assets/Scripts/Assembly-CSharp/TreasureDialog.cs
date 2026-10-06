using UnityEngine;

public class TreasureDialog : MonoBehaviour
{
	public delegate void ConfirmResult(bool decide, eHuntReturnType retType, int wealthKind);

	[SerializeField]
	private TreasureDialogImmidiate m_sImmidiate;

	[SerializeField]
	private TreasureDialogDepartureConfirm m_sDepartureConfirm;

	public void InitDepartureConfirm(HuntInfo info, ConfirmResult onResult)
	{
	}

	public void InitImmidiate(HuntInfo info, ConfirmResult onResult)
	{
	}

	public static TreasureDialog Create()
	{
		return null;
	}
}
