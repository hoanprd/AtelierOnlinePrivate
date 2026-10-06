using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class BattleResultManager : MonoBehaviour
{
	public Transform m_trInfoRoot;

	public GameObject m_goInfo;

	public GameObject m_goEndButton;

	public GameObject[] m_goDisableObjArray;

	private BattleResultInfo m_sInfo;

	private GameObject m_sSkipButton;

	private Action m_sEndCallback;

	private bool m_bEnd;

	private bool m_bStart;

	private QuestComplete[] m_sClearQuest;

	private BattleFinish m_bBattleFinishInfo;

	private LevelUpManager m_LevelUpWindow;

	private int m_LevelUpWidCount;

	private int m_LevelUpCount;

	private bool m_bEndBtn;

	public GameObject m_goABInfo;

	private GameObject m_ABResult;

	public bool IsAnimEnd
	{
		get
		{
			return false;
		}
	}

	public bool IsEnd
	{
		get
		{
			return false;
		}
	}

	private void Update()
	{
	}

	private void QuestCheck()
	{
	}

	public void Init()
	{
	}

	public void SetEnable(bool sw)
	{
	}

	public void DispStart(List<InventoryInfo> dropItem, BattleFinish ResultInfo, List<APIBattleFinish.Request.UseSkill> useSkillList, Action callback = null)
	{
	}

	public void SetClearQuest(string[] name)
	{
	}

	public void OnSkipButton()
	{
	}

	public void OnEndButton()
	{
	}

	[DebuggerHidden]
	private IEnumerator LevelUp(int index)
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator PerfEnd()
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator End()
	{
		return null;
	}

	public void ABDispStart(BattleFinish ResultInfo, MultiPlay_BattleData battleData)
	{
	}

	private void ABEnd()
	{
	}

	public void SetEnableAB(bool sw)
	{
	}
}
