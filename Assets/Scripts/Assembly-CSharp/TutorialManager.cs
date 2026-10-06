using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Tutorial;
using UnityEngine;

public class TutorialManager : SingletonBase<TutorialManager>
{
	public enum eMainStep
	{
		Wait = 0,
		LoadAsset_Init = 1,
		LoadAsset_Wait = 2,
		Make = 3,
		Control_Init = 4,
		Control_Wait = 5,
		SendFlag_Init = 6,
		SendFlag_Wait = 7,
		End = 8
	}

	private static readonly string sr_strIgnoreMaskTag;

	private bool[] m_bFlagAry;

	private eTutorial m_eNowTutorial;

	private DataUnit m_clsDataUnit;

	private int m_iNowDataIndex;

	private Data m_clsNowData;

	private eMainStep m_eStep;

	private bool m_bCommandEnd;

	private bool m_bAPIEnd;

	private Action<eTutorial, bool, bool> m_clsCallBack;

	private TutorialCommandBase m_scrCommand;

	private bool m_bForceEnd;

	private Dictionary<UICamera, int> m_iEventMaskDic;

	private bool m_bSkip;

	[SerializeField]
	private GameObject m_goCollider;

	protected override void Awake()
	{
	}

	private void Update()
	{
	}

	private void SwitchObjectState()
	{
	}

	private void LoadAsset_Init()
	{
	}

	private bool LoadAsset_Wait()
	{
		return false;
	}

	private void Make()
	{
	}

	private void MakeDialog(string strTitle, string strMessage, string strButtonName = "")
	{
	}

	private void Control_Init()
	{
	}

	private bool Control_Wait()
	{
		return false;
	}

	private void SendFlag_Init()
	{
	}

	private bool SendFlag_Wait()
	{
		return false;
	}

	[DebuggerHidden]
	private IEnumerator SendTutorialFlag_Private(List<eTutorial> eSendList)
	{
		return null;
	}

	[DebuggerHidden]
	public IEnumerator SendTutorialFlag(List<eTutorial> eSendList)
	{
		return null;
	}

	private void End()
	{
	}

	private void OnDialogCommon(EButtonKind eResult)
	{
	}

	private bool IsOutOfTutorialRange(int iKind)
	{
		return false;
	}

	public void SetCameraMask()
	{
	}

	public void UndoCameraMask()
	{
	}

	public bool IsCameraMask()
	{
		return false;
	}

	public bool ExecTutorial(eTutorial eKind, Action<eTutorial, bool, bool> clsCallBack = null, bool bForce = false)
	{
		return false;
	}

	public bool GetFlag(eTutorial eKind)
	{
		return false;
	}

	public void SetFlag(eTutorial eKind, bool bFlag = true)
	{
	}

	public void SetFlag_DF(int iDF, bool bFlag = true)
	{
	}

	public void SetAllFlag(bool bFlag)
	{
	}

	public eTutorial GetNowTutorial()
	{
		return eTutorial.Main01_Academy001;
	}

	public eExecKind GetNowCommand()
	{
		return eExecKind.ADV;
	}

	public bool IsMoveOK()
	{
		return false;
	}

	public bool IsTouchOK()
	{
		return false;
	}

	public bool IsPrevTouch()
	{
		return false;
	}

	public bool IsExec()
	{
		return false;
	}

	public bool IsEnd()
	{
		return false;
	}

	public bool IsRequestButtonNow()
	{
		return false;
	}

	public bool IsRequestButtonNow(string strName)
	{
		return false;
	}

	public bool IsMakeButtonArrow(string strName)
	{
		return false;
	}

	public bool ClickedButton(string strName)
	{
		return false;
	}

	public void SetSkip(bool bSkip)
	{
	}

	public void ForceEnd()
	{
	}
}
