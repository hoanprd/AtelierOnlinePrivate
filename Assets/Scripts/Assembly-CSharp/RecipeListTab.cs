using System;
using UnityEngine;

public class RecipeListTab : MonoBehaviour
{
	public int m_iToggleGroupID;

	public RecipeListTabItem[] m_asTabs;

	private RecipeListTabItem m_sSelectItem;

	private Action<ECategory> m_sChangeNotify;

	public ECategory SelectKind
	{
		get
		{
			return ECategory.eNONE;
		}
	}

	public void Init(ECategory defaultKind, Action<ECategory> notify, int group = -1)
	{
	}

	public void ChangeToggleGroup(int group)
	{
	}

	public void OnChange(RecipeListTabItem target)
	{
	}
}
