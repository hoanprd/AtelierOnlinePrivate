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
			return null;
		}
	}

	public static GuideManager Guide
	{
		get
		{
			return null;
		}
	}

	public static InventoryListManager Inventory
	{
		get
		{
			return null;
		}
	}

	public static CompositeManager Composite
	{
		get
		{
			return null;
		}
	}

	public static AreaTitle AreaTitle
	{
		get
		{
			return null;
		}
	}

	public static PartyTopManager Party
	{
		get
		{
			return null;
		}
	}

	public static ExqRoomManager ExqRoom
	{
		get
		{
			return null;
		}
	}

	public static Game_UI_OverHeadIcon OverHead
	{
		get
		{
			return null;
		}
	}

	public void AdjustList()
	{
	}

	protected override void Awake()
	{
	}

	public void DispDisable()
	{
	}

	public void CreateInstance()
	{
	}

	[DebuggerHidden]
	private IEnumerator Load()
	{
		return null;
	}

	public void ForceCancel()
	{
	}

	public void AddUI(string path, bool always = false)
	{
	}

	public void RegistUI(GameObject obj, bool always = false)
	{
	}
}
