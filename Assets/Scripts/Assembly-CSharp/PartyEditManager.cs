using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PartyEditManager : MonoBehaviour
{
	private enum EStatus
	{
		eINIT = 0,
		eDISP = 1,
		eSELECT = 2,
		eEND = 3
	}

	[SerializeField]
	private UILabel m_sTitle;

	[SerializeField]
	private UIButton m_sMemberEditButton;

	[SerializeField]
	private AnimationController m_sAnim;

	[SerializeField]
	private AnimationController m_sMainMenuAnim;

	[SerializeField]
	private PartyEditMemberList m_sMemberList;

	[SerializeField]
	private PartyEditFormation m_sFormationChange;

	[SerializeField]
	private SpawnPrefabData m_sItemSetting;

	private PartyInfo m_sPartyInfo;

	private EStatus m_eStatus;

	private PartyEditMemberInfo m_sTarget;

	private PartyEditRequest m_sRequest;

	private EPartyMode m_eNext;

	private int m_iTargetChara;

	private Coroutine m_sExitMemberCoroutine;

	private const int ciMEMBER_DISP_MAX = 4;

	public static List<CharaDetail> s_vCharaDetailList;

	private void OnDisable()
	{
	}

	public void Init(PartyInfo info, PartyEditRequest req)
	{
	}

	private void OnCloseEnd()
	{
	}

	public void OnClose()
	{
	}

	public void OnEditBattleItem()
	{
	}

	public void OnTraining(PartyMember target)
	{
	}

	public void OnEquipment(PartyMember target)
	{
	}

	[DebuggerHidden]
	private IEnumerator ExitMenu()
	{
		return null;
	}

	public void OnSwitchUsetItem(PartyEditMemberInfo select)
	{
	}

	public void OnCancel()
	{
	}

	[DebuggerHidden]
	private IEnumerator ExitMemberChange()
	{
		return null;
	}

	public void OnMemberChange()
	{
	}

	[DebuggerHidden]
	private IEnumerator StartMemberChange()
	{
		return null;
	}
}
