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
			this.mes = mes;
			this.se = se;
		}

		public Guide(string mes, int chara)
		{
			this.mes = mes;
			this.voice = chara;
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

	private List<Guide> m_vContentList = new List<Guide>();

	private GuideInfo m_sInfo;

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

	protected override void Awake()
	{
		base.Awake();
		if (m_vContentList == null)
		{
			m_vContentList = new List<Guide>();
		}
		gameObject.SetActive(false);
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
		if (m_vContentList == null)
		{
			m_vContentList = new List<Guide>();
		}
		m_vContentList.Add(new Guide(msg, sound));
		gameObject.SetActive(true);
	}

	public void InitRecipe(int leader)
	{
	}

	public void Init(string[] msg, eSoundID sound = eSoundID.system_011)
	{
		if (msg != null)
		{
			for (int i = 0; i < msg.Length; i++)
			{
				Init(msg[i], sound);
			}
		}
	}

	public void Init(QuestComplete[] clear)
	{
	}

	public void Init(string[] clear)
	{
		if (clear != null)
		{
			for (int i = 0; i < clear.Length; i++)
			{
				Init(clear[i]);
			}
		}
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
		if (m_eStep == EStep.eWAIT)
		{
			if (m_vContentList == null || m_vContentList.Count < 1)
			{
				gameObject.SetActive(false);
				return;
			}
		}
	}
}
