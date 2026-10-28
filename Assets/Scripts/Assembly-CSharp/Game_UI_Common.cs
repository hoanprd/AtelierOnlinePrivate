using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class Game_UI_Common : SingletonBase<Game_UI_Common>
{
	public Transform m_trAlwaysRoot;

	public Transform m_trCancelEnableRoot;

	public GameObject[] m_agoCreateAlwaysPrefabs;

	public GameObject[] m_agoCreatePrefabs;

	private AlterManager m_sAlter;

	private GuideManager m_sGuide;

	private LegendRecipeGuideManager m_sLegendRecipeGuide;

	private InventoryListManager m_sInventoryList;

	private CompositeManager m_sComposite;

	private AreaTitle m_sAreaTitle;

	private PartyTopManager m_sParty;

	private ExqRoomManager m_sExqRoom;

	private Game_UI_OverHeadIcon m_sOverHeadIcon;

	public static AlterManager Alter
	{
		get
		{
			return SingletonBase<Game_UI_Common>.IsExist ? SingletonBase<Game_UI_Common>.Instance.m_sAlter : null;
		}
	}

	public static GuideManager Guide
	{
		get
		{
			return SingletonBase<Game_UI_Common>.IsExist ? SingletonBase<Game_UI_Common>.Instance.m_sGuide : null;
		}
	}

	public static InventoryListManager Inventory
	{
		get
		{
			return SingletonBase<Game_UI_Common>.IsExist ? SingletonBase<Game_UI_Common>.Instance.m_sInventoryList : null;
		}
	}

	public static CompositeManager Composite
	{
		get
		{
			return SingletonBase<Game_UI_Common>.IsExist ? SingletonBase<Game_UI_Common>.Instance.m_sComposite : null;
		}
	}

	public static AreaTitle AreaTitle
	{
		get
		{
			return SingletonBase<Game_UI_Common>.IsExist ? SingletonBase<Game_UI_Common>.Instance.m_sAreaTitle : null;
		}
	}

	public static PartyTopManager Party
	{
		get
		{
			return SingletonBase<Game_UI_Common>.IsExist ? SingletonBase<Game_UI_Common>.Instance.m_sParty : null;
		}
	}

	public static ExqRoomManager ExqRoom
	{
		get
		{
			return SingletonBase<Game_UI_Common>.IsExist ? SingletonBase<Game_UI_Common>.Instance.m_sExqRoom : null;
		}
	}

	public static Game_UI_OverHeadIcon OverHead
	{
		get
		{
			return SingletonBase<Game_UI_Common>.IsExist ? SingletonBase<Game_UI_Common>.Instance.m_sOverHeadIcon : null;
		}
	}

	public void AdjustList()
	{
	}

	protected override void Awake()
	{
		base.Awake();
		CreateInstance();
	}

	public void DispDisable()
	{
		if (m_sAlter != null)
		{
			m_sAlter.gameObject.SetActive(false);
		}
		if (m_sParty != null)
		{
			m_sParty.gameObject.SetActive(false);
		}
		if (m_sExqRoom != null)
		{
			m_sExqRoom.gameObject.SetActive(false);
		}
		if (m_sInventoryList != null)
		{
			m_sInventoryList.gameObject.SetActive(false);
		}
		if (m_sComposite != null)
		{
			m_sComposite.gameObject.SetActive(false);
		}
		if (SingletonBase<Game_UI_GateMap>.IsExist)
		{
			SingletonBase<Game_UI_GateMap>.Instance.ForceExit();
		}
	}

	public void CreateInstance()
	{
		StartCoroutine(Load());
	}

	[DebuggerHidden]
	private IEnumerator Load()
	{
		while (System_MenuManager.GetInst() == null || !System_MenuManager.GetInst().IsDone)
		{
			yield return null;
		}
		if (m_trAlwaysRoot != null)
		{
			for (int i = m_trAlwaysRoot.childCount - 1; i >= 0; i--)
			{
				Object.Destroy(m_trAlwaysRoot.GetChild(i).gameObject);
			}
		}
		if (m_trCancelEnableRoot != null)
		{
			for (int j = m_trCancelEnableRoot.childCount - 1; j >= 0; j--)
			{
				Object.Destroy(m_trCancelEnableRoot.GetChild(j).gameObject);
			}
		}
		yield return null;
		if (m_agoCreatePrefabs != null && m_trCancelEnableRoot != null)
		{
			for (int k = 0; k < m_agoCreatePrefabs.Length; k++)
			{
				if (m_agoCreatePrefabs[k] != null)
				{
					GameObject inst = Util.InstantiateInChildren(m_agoCreatePrefabs[k], m_trCancelEnableRoot, false, false, true);
					if (inst != null)
					{
						Util.SetLayerRecursively(inst, base.gameObject.layer);
					}
				}
			}
		}
		if (m_agoCreateAlwaysPrefabs != null && m_trAlwaysRoot != null)
		{
			for (int l = 0; l < m_agoCreateAlwaysPrefabs.Length; l++)
			{
				if (m_agoCreateAlwaysPrefabs[l] != null)
				{
					GameObject inst2 = Util.InstantiateInChildren(m_agoCreateAlwaysPrefabs[l], m_trAlwaysRoot, false, false, true);
					if (inst2 != null)
					{
						Util.SetLayerRecursively(inst2, base.gameObject.layer);
					}
				}
			}
		}
		m_sAlter = GetComponentInChildren<AlterManager>(true);
		m_sGuide = GetComponentInChildren<GuideManager>(true);
		m_sLegendRecipeGuide = GetComponentInChildren<LegendRecipeGuideManager>(true);
		m_sInventoryList = GetComponentInChildren<InventoryListManager>(true);
		m_sComposite = GetComponentInChildren<CompositeManager>(true);
		m_sAreaTitle = GetComponentInChildren<AreaTitle>(true);
		m_sParty = GetComponentInChildren<PartyTopManager>(true);
		m_sExqRoom = GetComponentInChildren<ExqRoomManager>(true);
		m_sOverHeadIcon = GetComponentInChildren<Game_UI_OverHeadIcon>(true);
		DispDisable();
	}

	public void ForceCancel()
	{
		DispDisable();
	}

	public void AddUI(string path, bool always = false)
	{
		if (string.IsNullOrEmpty(path))
		{
			return;
		}
		GameObject prefab = Resources.Load<GameObject>(path);
		if (prefab != null)
		{
			RegistUI(prefab, always);
		}
	}

	public void RegistUI(GameObject obj, bool always = false)
	{
		if (obj == null)
		{
			return;
		}
		Transform parent = always ? m_trAlwaysRoot : m_trCancelEnableRoot;
		if (parent != null)
		{
			GameObject inst = Util.InstantiateInChildren(obj, parent, false, false, true);
			if (inst != null)
			{
				Util.SetLayerRecursively(inst, base.gameObject.layer);
			}
		}
	}
}
