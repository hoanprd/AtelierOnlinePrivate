using System.Collections.Generic;
using UnityEngine;

public class AlterExecuteWindow : MonoBehaviour
{
	[SerializeField]
	private UILabel m_sExecuteTitle;

	[SerializeField]
	private SpawnPrefabData m_sResult;

	[SerializeField]
	private UILabel m_sAlterLevel;

	[SerializeField]
	private UILabel m_sEXP;

	[SerializeField]
	private UILabel m_sMana;

	[SerializeField]
	private UILabel m_sSpoon;

	[SerializeField]
	private GameObject m_goMaterialPrefab;

	[SerializeField]
	private Transform[] m_atrMaterialRoot;

	[SerializeField]
	private AnimationController m_sAnimation;

	[SerializeField]
	private UILabel m_sSort;

	[SerializeField]
	private AlterExecuteMaterialSelect m_sSelectDecide;

	[SerializeField]
	private Transform m_trSelectWindowRoot;

	[SerializeField]
	private GameObject m_goSelectWindowPrefab;

	[SerializeField]
	private SpawnPrefabData m_sSkillSearchWindow;

	[SerializeField]
	private Transform m_trDetailRoot;

	[SerializeField]
	private GameObject m_goDetailPrefab;

	[SerializeField]
	private AlterExecuteResultIcon m_sExecuteIcon;

	[SerializeField]
	private AlterExecuteEffect m_sExecuteEffect;

	[SerializeField]
	private AlterExecuteButton m_sExecuteButton;

	[SerializeField]
	private AlterExecuteResultInfo m_sExpectationWindow;

	[SerializeField]
	private UIWindowBase m_sHelpWindow;

	public Game_UI_AlchemyInfo m_AlchemyInfo;

	private DialogCommon m_sCommonDiag;

	private AlterExecuteMaterialInfo m_sExtraMaterial;

	private MasterItem m_sItemMaster;

	private ItemSelectWindow m_sSelectWindow;

	private ItemDetailWindow m_sDetailWindow;

	private bool m_bDescentRarityOrder;

	private bool m_bExecute;

	private List<InventoryInfo> m_vIngredients;

	private InventoryInfo m_sExtraIngredient;

	private AlterExecuteMaterialInfo m_sSelectMaterial;

	private List<InventoryInfo> m_vInventoryList;

	private MasterItem m_sExtraItemMaster;

	private List<InventoryInfo> m_vIgnoreInventory;

	private EQuality m_eExpectationQuarity;

	private AlchemyConfirm.Item m_sExpectation;

	private bool m_bAlter;

	private bool m_bOnceQuit;

	private AlterResultManager m_sResultWindow;

	private List<InventoryInfo> m_vTraitList;

	private List<InventoryInfo> m_vCreateList;

	private List<InventoryInfo> m_vUseList;

	private const string csWARNING_KEY = "ALTER_WARNING";

	public bool IsAlter
	{
		get
		{
			return false;
		}
	}

	public List<InventoryInfo> CreateList
	{
		get
		{
			return null;
		}
	}

	public List<InventoryInfo> UseList
	{
		get
		{
			return null;
		}
	}

	public MasterItem TargetItem
	{
		get
		{
			return null;
		}
	}

	private void InitIngrediendObject()
	{
	}

	public void Init(int recipeID, List<InventoryInfo> inventory, List<InventoryInfo> ignoreInventory, bool once = false)
	{
	}

	private void InitIngredients(bool update = true)
	{
	}

	private void ModifyIngredients()
	{
	}

	private List<InventoryInfo> ChoiceIngredient(MasterItem.RecipeInfo ing)
	{
		return null;
	}

	private void AddExtra()
	{
	}

	private void CalcResult()
	{
	}

	public void OnSwitchSort()
	{
	}

	public void OnMaterialDetailWindow(AlterExecuteMaterialInfo info)
	{
	}

	public void OnSelect(AlterExecuteMaterialInfo info)
	{
	}

	private void UpdateMaterial(InventoryList inv, int updateFav, int gotoAlter)
	{
	}

	private void DispSelectExtraWindow(AlterExecuteMaterialInfo select)
	{
	}

	private void CreateSelectWindow()
	{
	}

	public void OnExecute()
	{
	}

	private void ExecuteAlter()
	{
	}

	private void OnCloseResult()
	{
	}

	private void OnUpdateStatus()
	{
	}

	private void EndTutorial(eTutorial kind, bool success, bool skip)
	{
	}

	private void OnDisable()
	{
	}

	public void OnCancel()
	{
	}

	public void OnResultDetail()
	{
	}

	public void OnMaterialDetail(InventoryInfo material)
	{
	}

	public void OnMaterialDetailFromID(long inventoryID)
	{
	}

	public void OnDecideMaterialChange()
	{
	}

	public void OnMaterialChange(List<InventoryInfo> materialList)
	{
	}

	public void OnExtraMaterialChange(InventoryInfo material)
	{
	}

	private void Confirm()
	{
	}

	private void UpdateConfirm(ResponseDataCommon common, AlchemyConfirm res)
	{
	}

	private List<InventoryInfo> GetUseMaterial()
	{
		return null;
	}

	public void OnDispHelpQuarity()
	{
	}

	public void AllClose()
	{
	}

	public bool IsAllClose()
	{
		return false;
	}
}
