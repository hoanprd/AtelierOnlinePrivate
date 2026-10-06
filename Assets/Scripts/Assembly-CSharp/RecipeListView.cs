using System.Collections.Generic;
using UnityEngine;

public class RecipeListView : UIWrapListBase
{
	[SerializeField]
	private GameObject m_goListItemPrefab;

	[SerializeField]
	private int m_iLineNum;

	protected List<RecipeInfo> m_vRecipeList;

	public void Init(List<RecipeInfo> recipe)
	{
	}

	public void Modity(RecipeList recipe)
	{
	}

	public void Reset()
	{
	}

	protected override void InitItem(int index, GameObject target)
	{
	}
}
