using System;
using System.Collections.Generic;
using UnityEngine;

public class AssetLoader : MonoBehaviour
{
	private enum eLoadStep
	{
		Load = 0,
		Check = 1,
		RetryConfirm = 2,
		Unload = 3,
		End = 4
	}

	public enum eFailedProc
	{
		RetryOnly = 0,
		ConfirmDialog = 1,
		CallBack = 2,
		Ignore = 3,
		EndlessRetry = 4,
		EnumMax = 5
	}

	public enum eRetry
	{
		Retry = 0,
		GiveUp = 1
	}

	private List<string> m_strPathList;

	private eLoadStep m_eLoadStep;

	private bool m_bStart;

	private eFailedProc m_eFailedProc;

	private eRetry m_eRetry;

	private bool m_bEndConfirmRetry;

	private Action<Action<eRetry>> m_acFailedCB;

	private bool m_bSuccess;

	private Action<bool> m_acEndCB;

	public bool IsEnd
	{
		get
		{
			return false;
		}
	}

	public bool IsSuccess
	{
		get
		{
			return false;
		}
	}

	public void Add(string strPath)
	{
	}

	public void Add(List<string> strPathList)
	{
	}

	public void SetMode(eFailedProc eMode, Action<Action<eRetry>> acFailedCB = null)
	{
	}

	public void Load(Action<bool> acEndCB = null, eFailedProc eMode = eFailedProc.EnumMax, Action<Action<eRetry>> acFailedCB = null)
	{
	}

	public void Kill()
	{
	}

	private void Update()
	{
	}

	private bool IsNeedLoad(string strPath)
	{
		return false;
	}

	private void ConfirmRetry(eFailedProc eMode)
	{
	}

	private void OnDialogEnd(EButtonKind eResult)
	{
	}

	private void OnFailedCBEnd(eRetry eResult)
	{
	}
}
