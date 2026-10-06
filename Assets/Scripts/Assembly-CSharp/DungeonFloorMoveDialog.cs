using System;
using System.Collections.Generic;
using UnityEngine;

public class DungeonFloorMoveDialog : MonoBehaviour
{
	public class FloorInfo
	{
		public int iFloor { get; private set; }

		public string strFloor { get; private set; }

		public string strName { get; private set; }

		public int iLv { get; private set; }

		public int iRoomIndex { get; private set; }

		public FloorInfo(int iFloor, string strFloor)
		{
		}

		public FloorInfo(int iFloor, string strFloor, string strName, int iLv, int iRoomIndex)
		{
		}
	}

	public enum eButton
	{
		Yes = 0,
		No = 1,
		Player = 2,
		WayPoint = 3,
		EnumMax = 4
	}

	private eButton m_eClickedButton;

	private int m_iOtherFloor;

	private Action<eButton, int> m_acCallBack;

	[SerializeField]
	private GameObject m_goRoot;

	[SerializeField]
	private UITweenReset m_scrTweenReset;

	[SerializeField]
	private DungeonFloorBarList m_scrWayPointBarList;

	[SerializeField]
	private DungeonFloorBarList m_scrBarList;

	[SerializeField]
	private GameObject m_goChildBase;

	[SerializeField]
	private GameObject m_goNoneChildObj;

	[SerializeField]
	private UILabel m_scrText;

	[SerializeField]
	private GameObject m_goWayPointRoot;

	private void Awake()
	{
	}

	private List<FloorInfo> MakeWayPointFloorList(int iMaxFloor)
	{
		return null;
	}

	private List<FloorInfo> MakePlayerFloorList(int iNextDungeonId, int iNextFloorId)
	{
		return null;
	}

	private void OnCommonDialog(EButtonKind eResult)
	{
	}

	private void SetDismiss()
	{
	}

	private void OnFinishedDismiss()
	{
	}

	public void SetText(string strRedText, string strBlackText)
	{
	}

	public void SetText(string strText)
	{
	}

	public void InitEnter(int iNextDungeonId, int iNextFloorId, Action<eButton, int> acCallBack)
	{
	}

	public void Init(int iNextDungeonId, int iNextFloorId, Action<eButton, int> acCallBack, bool bWayPoint = false)
	{
	}

	public bool IsOpen()
	{
		return false;
	}

	public void Close()
	{
	}

	public void ClickedButton(eButton eKind, FloorInfo clsInfo = null)
	{
	}
}
