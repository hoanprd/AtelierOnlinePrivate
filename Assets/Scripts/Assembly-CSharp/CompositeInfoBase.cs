using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public abstract class CompositeInfoBase : MonoBehaviour
{
	[Serializable]
	public class LevelUp
	{
		public GameObject goNum;

		public GameObject goTxt;

		public AnimEventCtrl sAnimEvent;

		public Animation sEventAnim;

		public Animation sAnim;

		public UILabel sBefore;

		public UILabel sAfter;

		public void Init()
		{
		}
	}

	protected bool m_bEnableAddEXP;

	protected bool m_bEnableAddLimitbreak;

	public bool IsEnableAddEXP
	{
		get
		{
			return false;
		}
	}

	public bool IsEnableAddLimitbreak
	{
		get
		{
			return false;
		}
	}

	public abstract void Init(CompositeTarget info);

	public abstract int SetFeed(List<CompositeMaterial> feeds);

	public abstract void GetEXP(CompositeMaterial feed, out int exp, out int cost);

	public abstract List<CompositeMaterial> GetRecommend(List<CompositeMaterial> feeds);

	public abstract void UpdateInfo(CompositeTarget info, RespireResult res);

	protected abstract IEnumerator OnUpdateInfo(CompositeTarget info, RespireResult res);

	[DebuggerHidden]
	protected IEnumerator LevelUpDirection(LevelUp target)
	{
		return null;
	}
}
