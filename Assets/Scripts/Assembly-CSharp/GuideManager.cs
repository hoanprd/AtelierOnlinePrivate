using System;
using System.Collections.Generic;
using UnityEngine;

public class GuideManager : SingletonBase<GuideManager>
{
	[Serializable]
	public class Guide
	{
		public string mes;

		public eSoundID se;

		public int voice;

		public Guide(string mes, eSoundID se = eSoundID.None)
		{
		}

		public Guide(string mes, int chara)
		{
		}
	}

	protected enum EStep
	{
		eWAIT = 0,
		eDISP = 1
	}

	public static readonly string scGET_RECIPE_WORD;

	public GameObject m_goPrefab;

	public Transform[] m_atrRoot;

	public UIGrid m_sGrid;

	private EStep m_eStep;

	private List<Guide> m_vContentList;

	private GuideInfo m_sInfo;

	public bool IsMove
	{
		get
		{
			return false;
		}
	}

	private void Reset()
	{
	}

	private T RegistItem<T>(Transform parent)
	{
		return default(T);
	}

	public void Init(string msg, eSoundID sound = eSoundID.system_011)
	{
	}

	public void InitRecipe(int leader)
	{
	}

	public void Init(string[] msg, eSoundID sound = eSoundID.system_011)
	{
	}

	public void Init(QuestComplete[] clear)
	{
	}

	public void Init(string[] clear)
	{
	}

	public void Init(QuestComplete clear, QuestDetail detail = null)
	{
	}

	public void Init(MasterQuestInfo[] qst)
	{
	}

	public void Init(MasterQuestInfo detail)
	{
	}

	private void Update()
	{
	}
}
