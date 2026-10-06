using System;
using System.Collections.Generic;
using UnityEngine;

public class LegendRecipeGuideManager : SingletonBase<LegendRecipeGuideManager>
{
	[Serializable]
	public class Guide
	{
		public string mes;

		public eSoundID se;

		public int voice;

		public int itemDF;

		public List<int> rcpCharaList;

		public bool start;

		public string rcpName;

		public Guide(string mes, eSoundID se = eSoundID.None, int df = 0)
		{
		}
	}

	protected enum EStep
	{
		eWAIT = 0,
		eDISP = 1
	}

	public static readonly string scGET_RECIPE_WORD;

	public static readonly int scLegend_RECIPE_LV;

	public bool m_bStartAnim;

	public GameObject m_goPrefab;

	private EStep m_eStep;

	private List<Guide> m_vContentList;

	private List<Guide> m_vPlayList;

	[SerializeField]
	private AnimationController m_Animation;

	[SerializeField]
	private UITexture m_txItem;

	[SerializeField]
	private UILabel m_recipeNameLab;

	public bool IsMove
	{
		get
		{
			return false;
		}
	}

	public bool Exists
	{
		get
		{
			return false;
		}
	}

	public bool IsFinish
	{
		get
		{
			return false;
		}
	}

	public bool IsPlaying
	{
		get
		{
			return false;
		}
	}

	public void Play(int charaDF, int level)
	{
	}

	private T RegistItem<T>(Transform parent)
	{
		return default(T);
	}

	public void Init(int itemDF, eSoundID sound = eSoundID.system_011)
	{
	}

	private void Update()
	{
	}
}
