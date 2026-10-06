using System.Collections.Generic;
using UnityEngine;

public class ItemDetailWindow : MonoBehaviour
{
	public delegate void CloseEvent(InventoryList updateInventory, int updateFav, int gotoAlter);

	public delegate void SimpleCloseEvent();

	[SerializeField]
	private SpawnPrefabData m_sFairyPickWindow;

	[SerializeField]
	private Transform[] m_atrItemRoot;

	[SerializeField]
	private Transform[] m_atrEquipRoot;

	[SerializeField]
	private Transform[] m_atrEnemyRoot;

	[SerializeField]
	private UIButton m_sAlterButton;

	[SerializeField]
	private ItemDetailBase m_sItemInfo;

	[SerializeField]
	private ItemDetailEquipment m_sEquipInfo;

	[SerializeField]
	private ItemDetailEnemy m_sEnemyInfo;

	[SerializeField]
	private ItemDetailHowtoGet m_sHowto;

	[SerializeField]
	private ItemDetailAlterList m_sAlterList;

	private ItemDetailBase m_sActiveWindow;

	private CloseEvent m_sOnCloseEvent;

	private SimpleCloseEvent m_sOnSimpleClose;

	private InventoryList m_sInventoryList;

	private int m_iGotoAlter;

	private int m_iUpdateFav;

	private void OnDiable()
	{
	}

	public void Bringin()
	{
	}

	public void Dismiss()
	{
	}

	public void OnExit()
	{
	}

	private void InitEvent(CloseEvent onCloseEvent = null, SimpleCloseEvent onSimpleClose = null)
	{
	}

	public virtual void Init(AlchemyConfirm.Item expectation)
	{
	}

	public void InitHowto(int df, FairyItemInfo item, CloseEvent callback = null)
	{
	}

	public void InitAlterList(InventoryInfo inv, CloseEvent callback = null)
	{
	}

	public void InitRecipe(int recipeID)
	{
	}

	public void Init(int df, int lv, int quality, int qualitylimit, int trt)
	{
	}

	public void Init(int df)
	{
	}

	public void Init(InventoryInfo item, CloseEvent callback = null, bool alter = false)
	{
	}

	public void InitSample(InventoryInfo item)
	{
	}

	public void InitSample(int itemDF)
	{
	}

	public void InitAlterResult(InventoryInfo item)
	{
	}

	public void Init(EnemyInfo enemy, SimpleCloseEvent onClose = null)
	{
	}

	private ItemDetailEnemy GetEnemyWindow()
	{
		return null;
	}

	private ItemDetailBase GetWindow(MasterItem master)
	{
		return null;
	}

	private ItemDetailBase GetWindow(ECategory category)
	{
		return null;
	}

	public void OnFairy(ItemDetailHowtoGetItem info)
	{
	}

	private void OnExitFairyWindow(InventoryList add)
	{
	}

	private void InitAlterList(InventoryInfo inv, List<MasterItem> list, CloseEvent callback = null)
	{
	}

	public void OnGotoAlter(int recipeID)
	{
	}

	public static ItemDetailWindow Create(Transform root)
	{
		return null;
	}
}
