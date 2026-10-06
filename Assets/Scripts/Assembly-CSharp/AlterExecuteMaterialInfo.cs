using System.Collections.Generic;
using UnityEngine;

public class AlterExecuteMaterialInfo : MonoBehaviour
{
	public UILabel m_sEnoughNum;

	public UITexture m_txPicture;

	public UILabel m_sSelect;

	public UILabel m_sAmount;

	public GameObject m_goNotEnough;

	public GameObject m_goSet;

	public AlterExecuteMaterialGraph m_sQuarityGraph;

	public UIButton m_sDetailButton;

	private MasterItem.RecipeInfo m_sIngredient;

	private List<InventoryInfo> m_vMaterials;

	private List<InventoryInfo> m_vInventory;

	private bool m_bFree;

	public List<InventoryInfo> Materials
	{
		get
		{
			return null;
		}
	}

	public MasterItem.RecipeInfo IngredientInfo
	{
		get
		{
			return null;
		}
	}

	public void ModifyEnough(List<InventoryInfo> all)
	{
	}

	public void Modity(List<InventoryInfo> ingredients)
	{
	}

	public void ModityExtra(InventoryInfo ingredient)
	{
	}

	public void ModifyList(List<InventoryInfo> list, bool update = true)
	{
	}

	public void Init(MasterItem.RecipeInfo ingredient, List<InventoryInfo> use, List<InventoryInfo> list, bool update = true)
	{
	}

	private void SetNeedNum(int need, int have)
	{
	}
}
