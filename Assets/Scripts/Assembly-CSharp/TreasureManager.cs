using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class TreasureManager : UIListViewBase<TreasurePartyItem>
{
	[SerializeField]
	private UITexture m_txCharacter;

	[SerializeField]
	private UILabel m_sTalk;

	[SerializeField]
	private UILabel m_sTalkerName;

	[SerializeField]
	private TypewriterEffect m_sTypewriter;

	[SerializeField]
	private AnimationController m_sAnim;

	[SerializeField]
	private UITweenReset m_sSerifAnim;

	[SerializeField]
	private TreasureTargetList m_sTargetList;

	[SerializeField]
	private TreasurePreparation m_sPreparation;

	private HuntStatus m_sInfo;

	private List<HuntInfo> m_vInfoList;

	private MasterTreasure m_sMasterMessage;

	private TreasurePartyItem m_sEditTarget;

	private HuntInfo m_sSelectInfo;

	private bool m_bSuspended;

	private Action<HuntStatus> m_sOnCloseEvent;

	private void OnEnable()
	{
	}

	public void Init(HuntStatus stat, Action<HuntStatus> onResult)
	{
	}

	private void Init()
	{
	}

	private void Init(HuntStatus stat)
	{
	}

	private void InitTalk()
	{
	}

	private PartyMember GetTalkTarget(List<HuntInfo> list)
	{
		return null;
	}

	private void InitInfo(HuntStatus stat)
	{
	}

	public void OnReset()
	{
	}

	private void ResetInfo()
	{
	}

	public void OnHowtoURL()
	{
	}

	public void OnSelectForm(TreasurePartyItem target)
	{
	}

	public void OnGiveup(HuntInfo target)
	{
	}

	public void OnImmidiate(HuntInfo info)
	{
	}

	private void OnImmidiateConfirmResult(bool decide, eHuntReturnType result, int wealthKind)
	{
	}

	public void OnResult(HuntInfo info)
	{
	}

	public void OnDetail(HuntInfo info)
	{
	}

	public void OnBack()
	{
	}

	private void OnCloseEnd()
	{
	}

	[DebuggerHidden]
	private IEnumerator Result(HuntResultInfo result)
	{
		return null;
	}

	private void OnApplicationPause(bool pause)
	{
	}

	public static TreasureManager Create(Transform root)
	{
		return null;
	}
}
