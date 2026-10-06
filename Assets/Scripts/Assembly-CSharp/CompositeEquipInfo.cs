using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CompositeEquipInfo : CompositeInfoBase
{
	public class LevelInfo
	{
		public int LV;

		public int MIN;

		public int MAX;

		public LevelInfo(int lv, int min, int max)
		{
		}
	}

	[Serializable]
	public class EXP
	{
		public UILabel sNow;

		public UILabel sNext;

		public UISlider sNowEXP;

		public UISlider sNextEXP;

		public UILabel sNextEXPValue;

		public GameObject goNextArrow;

		public List<LevelInfo> vEXPTable;

		public void CreateTable(Formula coef, int start)
		{
		}

		public virtual LevelInfo SetEXP(int nowEXP, int addEXP, int nowLV, int maxLV)
		{
			return null;
		}

		protected virtual void SetNextLV(bool lvup, bool limitup, int lv, int max)
		{
		}

		protected virtual void SetNowLV(int now, int max)
		{
		}
	}

	[Serializable]
	public class QualityEXP : EXP
	{
		public CompositeLimitbreakMark sLimitbreakMark;

		public LevelInfo SetEXP(int nowEXP, int addEXP, int nowLV, int maxLV, bool reset)
		{
			return null;
		}

		protected override void SetNextLV(bool lvup, bool limitup, int lv, int max)
		{
		}

		protected override void SetNowLV(int now, int max)
		{
		}
	}

	[SerializeField]
	private EXP m_sLevel;

	[SerializeField]
	private QualityEXP m_sQuality;

	[SerializeField]
	private Transform m_trItemBarRoot;

	[SerializeField]
	private UITexture m_txPicture;

	[SerializeField]
	private UITable m_sParamTable;

	[SerializeField]
	private CompositeEquipParamList m_sParam;

	[SerializeField]
	private EquipSkillList m_sActiveSkill;

	[SerializeField]
	private SkillMark m_sSpecialSkill;

	[SerializeField]
	private EquipJobList m_sJobList;

	public CompositeEquipLvUp m_EquipLvUp;

	public LevelUp m_sQualityUpDir;

	public LevelUp m_sLevelUpDir;

	public GameObject m_arrowObj;

	private CompositeTarget m_sTarget;

	private const float cfCOST_RATE = 100f;

	private const float cfEXP_RATE = 0.25f;

	public void OnDisable()
	{
	}

	public override void Init(CompositeTarget info)
	{
	}

	private void Update()
	{
	}

	public void Reposition()
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

	public void InitLevel(CompositeTarget info)
	{
	}

	public void InitQuality(CompositeTarget info, bool reset)
	{
	}
}
