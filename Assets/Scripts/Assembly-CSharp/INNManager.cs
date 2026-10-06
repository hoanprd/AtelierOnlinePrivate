using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class INNManager : MonoBehaviour
{
	private UITweenReset m_scrBlackIn;

	private UITweenReset m_scrBlackOut;

	[SerializeField]
	private INNPopup m_scrPopup;

	[SerializeField]
	private INNCharaUIList m_scrCharaList;

	[SerializeField]
	private GameObject m_goBlack;

	private void Awake()
	{
	}

	private void OnDialogEnd(EButtonKind eResult)
	{
	}

	private void OnPopupClicked(INNPopup.eButton eResult)
	{
	}

	private void OnPopupEnd(INNPopup.eButton eResult)
	{
	}

	private void OnHealEnd()
	{
	}

	private void OnCharaDismissEnd()
	{
	}

	[DebuggerHidden]
	private IEnumerator HealIn()
	{
		return null;
	}

	public void Init(int iNeedCall)
	{
	}

	public bool IsEnd()
	{
		return false;
	}
}
