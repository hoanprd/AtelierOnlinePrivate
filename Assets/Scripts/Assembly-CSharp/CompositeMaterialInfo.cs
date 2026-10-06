using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CompositeMaterialInfo : CompositeInfoBase
{
	private class LevelInfo
	{
		public int QTY;

		public int MIN;

		public int MAX;
	}

	[SerializeField]
	private SkillMark m_sSkillMark;

	[SerializeField]
	private UITexture m_txIcon;

	[SerializeField]
	private UILabel m_sNowQuality;

	[SerializeField]
	private UILabel m_sNextQuality;

	[SerializeField]
	private UISlider m_sNowEXP;

	[SerializeField]
	private UISlider m_sNextEXP;

	[SerializeField]
	private UILabel m_sNextEXPValue;

	[SerializeField]
	private CompositeLimitbreakMark m_sLimitBreak;

	[SerializeField]
	private Transform m_trItemBarRoot;

	private CompositeTarget m_sTarget;

	public GameObject m_arrowObj;

	public GameObject m_TxtQualityUp;

	public GameObject m_NameQualityUp;

	public AnimEventCtrl m_NameQualityUpAnimEvent;

	public UILabel m_targetName;

	private List<LevelInfo> m_vLevelTable;

	private void OnDisable()
	{
	}

	public override void Init(CompositeTarget info)
	{
	}

	public override int SetFeed(List<CompositeMaterial> feeds)
	{
		return 0;
	}

	public override void GetEXP(CompositeMaterial feed, out int exp, out int cost)
	{
		exp = default(int);
		cost = default(int);
	}

	public override List<CompositeMaterial> GetRecommend(List<CompositeMaterial> feeds)
	{
		return null;
	}

	public override void UpdateInfo(CompositeTarget info, RespireResult res)
	{
	}

	[DebuggerHidden]
	protected override IEnumerator OnUpdateInfo(CompositeTarget info, RespireResult res)
	{
		return null;
	}
}
