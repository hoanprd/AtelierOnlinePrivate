using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Mission;
using UnityEngine;

public class MissionManager : MonoBehaviour
{
	public enum eButton
	{
		Daily = 0,
		Degree = 1,
		Event = 2,
		Close = 3,
		Filter = 4,
		EnumMax = 5
	}

	public class Sort
	{
		public ESortKind eSort;

		public EFilterKind eFilter;

		public EOrder eOrder;

		public string strSortKey;

		public string strFilterKey;

		public string strOrderKey;

		public Sort(string strSortKey, string strFilterKey, string strOrderKey)
		{
		}
	}

	private static readonly List<EFilterKind>[] sr_eFilterListAry;

	private Action m_acOnClose;

	private eMode m_eMode;

	private bool m_bNetWork;

	private DailyMissionInfo m_clsDaily;

	private List<DegreeMissionInfo> m_clsDegreeList;

	private List<DegreeMissionInfo> m_clsDegreeDispList;

	private SortFilterWindow m_scrSFWindow;

	private Sort[] m_clsSortAry;

	[SerializeField]
	private GameObject m_goActiveRoot;

	[SerializeField]
	private UITweenReset m_scrTween;

	[SerializeField]
	private UIButton[] m_scrButtonAry;

	[SerializeField]
	private MissionBarList m_scrBarList;

	[SerializeField]
	private UIToggle[] m_scrToggleAry;

	[SerializeField]
	private UILabel m_scrFilterLabel;

	[SerializeField]
	private GameObject m_goFilerObj;

	[SerializeField]
	private UIScrollView m_scrScroll;

	[SerializeField]
	private UILabel m_scrBadgeNum;

	[SerializeField]
	private UILabel m_scrBadgeNum_Ev;

	[SerializeField]
	private UILabel m_scrRestTime;

	private void Awake()
	{
	}

	private void OnDaily()
	{
	}

	private void OnDegree()
	{
	}

	private void OnEvent()
	{
	}

	private void OnModeTab(eMode eToMode, bool bForce = false)
	{
	}

	private void OnClose()
	{
	}

	private void OnCloseEnd()
	{
	}

	private void OnFilter()
	{
	}

	private void OnSFEnd(bool bUpdate)
	{
	}

	private List<DegreeMissionInfo> MakeDegreeDispList(Sort clsSort)
	{
		return null;
	}

	private void SetMode(eMode eReq)
	{
	}

	[DebuggerHidden]
	private IEnumerator InitAPI()
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator APIDailyMission()
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator APIDegreeMission()
	{
		return null;
	}

	private void UpdateBadge()
	{
	}

	private void UpdateRestTime()
	{
	}

	public void Init(eMode defaultMode = eMode.Daily, Action acOnClose = null)
	{
	}

	public static MissionManager Create(Transform root)
	{
		return null;
	}
}
