using System.Collections.Generic;
using UnityEngine;

public class AlterKeywordMaterialInfo : MonoBehaviour
{
	[SerializeField]
	private UILabel m_sName;

	[SerializeField]
	private UILabel m_sNeedNum;

	[SerializeField]
	private UISprite m_sCategoryIcon;

	[SerializeField]
	private GameObject m_goNotUseObject;

	[SerializeField]
	private GameObject m_goUseObject;

	private Ingredient m_sIngredient;

	private List<InventoryInfo> m_vMaterials;

	private UITweenReset m_sAnim;

	public List<InventoryInfo> Materials
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	public void Modity(List<InventoryInfo> ingredients)
	{
	}

	public void Init(Ingredient ingredient, List<InventoryInfo> use, bool update = true)
	{
	}
}
