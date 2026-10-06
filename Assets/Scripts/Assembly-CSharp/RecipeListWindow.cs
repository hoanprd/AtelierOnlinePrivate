using System;
using System.Collections.Generic;
using UnityEngine;

public class RecipeListWindow : MonoBehaviour
{
	public SortStateInfo m_sSortState;

	public Transform m_trSortWindowRoot;

	public UILabel m_sFilterName;

	public AnimationController m_sAnim;

	public RecipeListView m_sList;

	public RecipeListTab m_sEquipTab;

	public EventDelegate m_sOnClose;

	private Action<RecipeInfo> m_sSelectRecipe;

	private Action<RecipeInfo> m_sDetailRecipe;

	private ItemListFilterWindow m_sFilterWindow;

	private RecipeList m_sRecipeList;

	private List<RecipeInfo> m_vDispRecipeList;

	private EAlterKind m_eMainKind;

	private ECategory m_eCategory;

	private SortFilterWindow m_sSortFilterWindow;

	private ESortKind m_eSortKind;

	private EFilterKind m_eFilterKind;

	private EOrder m_eOrderKind;

	private const string SORT_PREFIX = "RECIPE_";

	public bool IsEnd
	{
		get
		{
			return false;
		}
	}

	public void Bringin()
	{
	}

	public void Dismiss()
	{
	}

	private void OnCloseEnd()
	{
	}

	protected bool IsEquip()
	{
		return false;
	}

	private void InitList()
	{
	}

	public void SetData(RecipeList list, Action<RecipeInfo> selectRecipe, Action<RecipeInfo> detailRecipe)
	{
	}

	public int GetEnableRecipeNum(EAlterKind kind)
	{
		return 0;
	}

	public int GetNewRecipeNum(EAlterKind kind)
	{
		return 0;
	}

	public void Init(EAlterKind category)
	{
	}

	public List<RecipeInfo> GetRecipeList(ECategory kind)
	{
		return null;
	}

	public void Modify(RecipeList recipe)
	{
	}

	public void ChangeTab(ECategory kind)
	{
	}

	public void OnSelectItem(RecipeInfo recipe)
	{
	}

	public void OnSelectRecipe(RecipeInfo recipe)
	{
	}

	public void OnRecipeDetail(RecipeInfo recipe)
	{
	}

	private ESortKind GetDefaultSortKind()
	{
		return ESortKind.eNO;
	}

	private void LoadSort()
	{
	}

	private void OnSortDecide(bool update)
	{
	}

	public void OnFilterButton()
	{
	}

	public void OnSortButton()
	{
	}

	private int Compare(RecipeInfo a, RecipeInfo b)
	{
		return 0;
	}

	private int CompareName(RecipeInfo a, RecipeInfo b)
	{
		return 0;
	}

	private int CompareATK(RecipeInfo a, RecipeInfo b)
	{
		return 0;
	}

	private int CompareMATK(RecipeInfo a, RecipeInfo b)
	{
		return 0;
	}

	private int CompareDEF(RecipeInfo a, RecipeInfo b)
	{
		return 0;
	}

	private int CompareMDEF(RecipeInfo a, RecipeInfo b)
	{
		return 0;
	}

	private int IsEnableAlter(RecipeInfo recipe)
	{
		return 0;
	}

	private int CompareAlter(RecipeInfo a, RecipeInfo b)
	{
		return 0;
	}

	private int CompareNew(RecipeInfo a, RecipeInfo b)
	{
		return 0;
	}
}
