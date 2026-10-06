using System;
using System.Collections.Generic;
using UnityEngine;

public class SkillSearchCategoryList : MonoBehaviour
{
	[Serializable]
	public class ListData
	{
		public UIScrollView sScrollView;

		public UIGrid sGrid;

		public GameObject goPrefab;

		public void Init()
		{
		}
	}

	[SerializeField]
	private ListData m_sCategoryList;

	[SerializeField]
	private ListData m_sSkillList;

	[SerializeField]
	private ListData m_sSelectList;

	[SerializeField]
	private UIButton m_sDecideButton;

	private List<int> m_vSelectList;

	private int m_iLargeCategory;

	private List<SkillCategRecord> m_vCategoryList;

	public List<int> Select
	{
		get
		{
			return null;
		}
	}

	public void Init(SkillSearchWindow.EInventoryKind kind)
	{
	}

	private void CreateLargeCategoryList()
	{
	}

	private void CreateCategoryList()
	{
	}

	private void CreateSelectList()
	{
	}

	public void OnSelectCategory(SkillSearchLineupItem target)
	{
	}

	public void OnSelectSkill(SkillSearchLineupItem target)
	{
	}

	public void OnRemoveSkill(SkillSearchSelectSkillItem target)
	{
	}

	public void OnAllSelect()
	{
	}

	public void OnAllRemove()
	{
	}
}
