using System;
using UnityEngine;

public class MissionDetailWindow : UIWindowBase
{
	[SerializeField]
	private MissionBar m_sInfo;

	[SerializeField]
	private UIButton m_sGotoQuestButton;

	private Action<int> m_sJumpQuestTabEvent;

	private DegreeMissionInfo m_sData;

	public void Init(DegreeMissionInfo info, Action<int> jumpQuestTabEvent)
	{
	}

	public void OnJumpSideQuestTab()
	{
	}
}
