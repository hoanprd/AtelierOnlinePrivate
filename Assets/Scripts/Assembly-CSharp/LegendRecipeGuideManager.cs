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
			this.mes = mes;
			this.se = se;
			this.itemDF = df;
			this.rcpCharaList = new List<int>();
			this.rcpName = string.Empty;
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

	private List<Guide> m_vContentList = new List<Guide>();

	private List<Guide> m_vPlayList = new List<Guide>();

	[SerializeField]
	private AnimationController m_Animation;

	[SerializeField]
	private UITexture m_txItem;

	[SerializeField]
	private UILabel m_recipeNameLab;

	protected override void Awake()
	{
		base.Awake();
		if (m_vContentList == null)
		{
			m_vContentList = new List<Guide>();
		}
		if (m_vPlayList == null)
		{
			m_vPlayList = new List<Guide>();
		}
		gameObject.SetActive(false);
	}

	public bool IsMove
	{
		get
		{
			if (m_vContentList == null || m_vContentList.Count < 1)
			{
				return false;
			}
			return gameObject.activeSelf;
		}
	}

	public bool Exists
	{
		get
		{
			return m_vContentList != null && m_vContentList.Count > 0;
		}
	}

	public bool IsFinish
	{
		get
		{
			if (m_vPlayList != null && m_vPlayList.Count > 0)
			{
				return false;
			}
			return m_vContentList == null || m_vContentList.Count < 1;
		}
	}

	public bool IsPlaying
	{
		get
		{
			return m_Animation != null && !m_Animation.IsAnimationEnd();
		}
	}

	public void Play(int charaDF, int level)
	{
		if (m_vContentList != null && m_vContentList.Count > 0)
		{
			gameObject.SetActive(true);
			for (int i = m_vContentList.Count - 1; i >= 0; i--)
			{
				Guide guide = m_vContentList[i];
				if (guide.rcpCharaList != null && guide.rcpCharaList.Contains(charaDF))
				{
					if (level >= scLegend_RECIPE_LV)
					{
						m_vPlayList.Add(guide);
						m_vContentList.RemoveAt(i);
					}
				}
			}
		}
	}

	private T RegistItem<T>(Transform parent)
	{
		return default(T);
	}

	public void Init(int itemDF, eSoundID sound = eSoundID.system_011)
	{
		if (m_vContentList == null)
		{
			m_vContentList = new List<Guide>();
		}
		m_vContentList.Add(new Guide(string.Empty, sound, itemDF));
	}

	private void Update()
	{
		if (m_eStep == EStep.eDISP)
		{
			if (m_Animation != null && m_Animation.IsAnimationEnd())
			{
				if (m_vPlayList != null && m_vPlayList.Count > 0)
				{
					m_vPlayList.RemoveAt(0);
				}
				m_eStep = EStep.eWAIT;
			}
		}
		else if (m_eStep == EStep.eWAIT)
		{
			if (m_vPlayList == null || m_vPlayList.Count < 1)
			{
				gameObject.SetActive(false);
				m_bStartAnim = false;
			}
			else
			{
				Guide guide = m_vPlayList[0];
				if (m_recipeNameLab != null)
				{
					m_recipeNameLab.text = guide.rcpName;
				}
				if (m_txItem != null)
				{
					UIAssetBundleTexture.Regist(UIDefine.GetItemMiniPicturePath(guide.itemDF), m_txItem);
				}
				if (m_Animation != null)
				{
					m_Animation.PlayInAnimation();
				}
				if (Sound_Manager.GetInst() != null)
				{
					Sound_Manager.GetInst().PlaySound(eSoundID.system_011);
				}
				m_eStep = EStep.eDISP;
			}
		}
	}
}
