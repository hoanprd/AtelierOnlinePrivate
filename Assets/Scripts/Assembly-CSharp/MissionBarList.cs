using System.Collections.Generic;
using Mission;
using UnityEngine;

public class MissionBarList : UIWrapListBase
{
	private eMode m_eMode;

	private List<DailyMissionInfo.Info> m_clsDailyList;

	private List<DegreeMissionInfo> m_clsDegreeList;

	private void Awake()
	{
	}

	public void Init(List<DailyMissionInfo.Info> clsList)
	{
	}

	public void Init(List<DegreeMissionInfo> clsList)
	{
	}

	public void Init()
	{
	}

	protected override void InitItem(int iIndex, GameObject goTarget)
	{
	}
}
