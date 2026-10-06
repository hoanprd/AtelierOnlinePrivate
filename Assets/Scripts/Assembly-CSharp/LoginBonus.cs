using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class LoginBonus : MonoBehaviour
{
	private enum ELoginBonusType
	{
		None = 0,
		Normal = 1,
		Event = 2,
		Special = 3
	}

	[SerializeField]
	private GameObject m_BaseItem;

	[SerializeField]
	private GameObject m_BaseStamp;

	[SerializeField]
	private GameObject m_ItemBar;

	[SerializeField]
	private GameObject m_GetItem;

	[SerializeField]
	private GameObject m_GetItemBar;

	[SerializeField]
	private GameObject m_NormalBase;

	[SerializeField]
	private GameObject m_EventBase;

	[SerializeField]
	private AnimationController m_AnimBase;

	private AnimationController m_AnimGetItem;

	private GameObject m_Stamp;

	private List<GameObject> m_ItemList;

	private List<GameObject> m_ItemInfoList;

	private bool m_Receved;

	private LoginBonusFlag m_nowLoginBonus;

	private HomeEnter.LoginBonusDailyInfo m_nowLoginBonusDay;

	private HomeEnter.LoginBonusDailyInfo m_nowLoginBonusTomorrow;

	private List<LoginBonusFlag> m_LoginBonusList;

	private int m_Count;

	public void Init(HomeEnter.LoginBonusResponse info)
	{
	}

	public void InitBonus()
	{
	}

	public void InitNextBonus()
	{
	}

	public void InitNext()
	{
	}

	public void NextPageSet()
	{
	}

	public void Stamp()
	{
	}

	public void GetItem()
	{
	}

	[DebuggerHidden]
	private IEnumerator ObserveNextpage()
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator ObserveStamp()
	{
		return null;
	}

	public void StampSE()
	{
	}

	[DebuggerHidden]
	private IEnumerator ObserveChagepage()
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator ObserveADV()
	{
		return null;
	}

	public void GetItemEnd()
	{
	}

	public void End()
	{
	}

	public bool IsFineished()
	{
		return false;
	}

	private string GetPeriodString(string startText, string endText)
	{
		return null;
	}
}
