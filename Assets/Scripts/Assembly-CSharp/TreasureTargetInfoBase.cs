using System;
using System.Collections.Generic;
using UnityEngine;

public class TreasureTargetInfoBase : MonoBehaviour
{
	public enum EStat
	{
		eNONE = 0,
		eRUNNING = 1,
		eDONE = 2
	}

	[Serializable]
	public class RemainTime
	{
		public UILabel sTime;

		public GameObject goRunning;

		public GameObject goNone;

		public GameObject goDone;

		public void Init(HuntInfo info)
		{
		}
	}

	[Serializable]
	public class Member
	{
		public UIGrid sGrid;

		public UITexture[] atxIcon;

		public void Init(List<FormationInfo> member)
		{
		}
	}

	[Serializable]
	public class Bonus
	{
		public UIGrid sGrid;

		public UILabel[] asLabel;

		public GameObject[] agoCheck;

		public virtual void Init(HuntInfo conditions)
		{
		}

		protected void Init(List<JoinCondition> conditions, bool required)
		{
		}

		protected void InitCheck(HuntInfo info, bool required)
		{
		}
	}

	[Serializable]
	public class Condition : Bonus
	{
		public override void Init(HuntInfo conditions)
		{
		}
	}

	[Serializable]
	public class Reward
	{
		public Transform trFeatureRoot;

		public Transform trRewardRoot;

		public Transform trDetailRoot;

		public UIGrid sGrid;

		public void Init(HuntReward reward)
		{
		}

		public void OnDetail(ItemBar target)
		{
		}
	}

	[Serializable]
	public class Formation
	{
		public UILabel sTime;

		public GameObject goNone;

		public GameObject goDone;

		public void Init(HuntInfo info)
		{
		}
	}

	public const int ciMEMBER_MAX = 5;

	[SerializeField]
	protected UILabel m_sName;

	[SerializeField]
	protected GameObject m_goEventMark;

	protected HuntInfo m_sInfo;

	public HuntInfo Info
	{
		get
		{
			return null;
		}
	}

	public virtual void Init(HuntInfo info)
	{
	}
}
