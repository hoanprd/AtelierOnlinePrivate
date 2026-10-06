using System;
using UnityEngine;

public class TreasurePartyItem : TreasureTargetInfoBase
{
	[Serializable]
	public class RunningInfo
	{
		public GameObject goRoot;

		public UIButton sDoneButton;

		public UIButton sDetailButton;

		public UIButton sGiveupButton;

		public UIButton sImmidiateReturnButton;

		public void Init(EStat stat)
		{
		}
	}

	[Serializable]
	public class NoneInfo
	{
		public GameObject goRoot;

		public UIButton sSettingButton;
	}

	[SerializeField]
	private Member m_sMemberList;

	[SerializeField]
	private RemainTime m_sRemainTime;

	[SerializeField]
	private RunningInfo m_sRunningInfo;

	[SerializeField]
	private NoneInfo m_sNoneInfo;

	private int m_iNo;

	public override void Init(HuntInfo info)
	{
	}

	public void Init(int no)
	{
	}
}
