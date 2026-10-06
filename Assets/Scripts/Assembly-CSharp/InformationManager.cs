using System.Collections.Generic;
using UnityEngine;

public class InformationManager : SingletonBase<InformationManager>
{
	protected enum EStep
	{
		eWAIT = 0,
		eBRINGIN = 1,
		eDISP = 2,
		eDISMISS = 3
	}

	public class Data
	{
		public string sContent;

		public int iGroup;
	}

	public float m_fDispDelay;

	public float m_fWaitTime;

	public GameObject m_goLabelRoot;

	public UITweenReset m_sAnim;

	public UILabel m_sLabel;

	private List<Data> m_vContentList;

	private EStep m_eStep;

	private float m_fTimer;

	public bool IsMove
	{
		get
		{
			return false;
		}
	}

	public void Clear(int group)
	{
	}

	public void Clear(bool all = true)
	{
	}

	public void Init(string msg, int group = 0)
	{
	}

	public void OnAnimEnd()
	{
	}

	private void Update()
	{
	}
}
