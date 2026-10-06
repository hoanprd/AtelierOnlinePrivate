using System.Collections.Generic;
using UnityEngine;

public class AlterManager : MonoBehaviour
{
	public delegate void AlterCallback(bool execute, List<InventoryInfo> createList, List<InventoryInfo> useList);

	public AnimationController m_sAnim;

	public UILabel[] m_asTitleList;

	public AnimationController m_sCategorySelect;

	public AlterExecuteWindow m_sExecuteWindow;

	public RecipeListWindow m_sRecipeList;

	public Transform m_trDetailRoot;

	public AlterCategoryButton[] m_asCategoryButton;

	private ItemDetailWindow m_sDetailWindow;

	private bool m_bActive;

	private EAlterKind m_eKind;

	private bool m_bAlterOnly;

	private AlterCallback m_sCallback;

	private UIButton m_sFoodBtn;

	private bool m_bCloseNow;

	public bool IsActive
	{
		get
		{
			return false;
		}
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Disp(AlterCallback onExit = null)
	{
	}

	public void Disp(int recipeID, AlterCallback onExit = null, bool onceQuit = true)
	{
	}

	public void Disp(int recipeID, List<InventoryInfo> inv, List<InventoryInfo> ignoreInventory, AlterCallback onExit = null, bool onceQuit = true)
	{
	}

	public void OnSelectRecipe(RecipeInfo recipe)
	{
	}

	public void OnDetailRecipe(RecipeInfo recipe)
	{
	}

	public void OnBack()
	{
	}

	public void OnDispCategorySelect()
	{
	}

	public void OnSelectCategory(EAlterKind kind)
	{
	}

	private void OnDispRecipe()
	{
	}

	private void Init(RecipeList list, AlterCallback onExit = null)
	{
	}

	private void DispExecuteWindow(int recipeID, List<InventoryInfo> inv, List<InventoryInfo> ignoreInventory = null, bool onceQuit = false)
	{
	}

	public void OnCloseExecuteWindow()
	{
	}

	private void OnDismiss()
	{
	}

	private void SetTitle()
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
