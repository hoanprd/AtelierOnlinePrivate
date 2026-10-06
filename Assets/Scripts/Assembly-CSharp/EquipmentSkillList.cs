using System.Collections.Generic;
using UnityEngine;

public class EquipmentSkillList : MonoBehaviour
{
	[SerializeField]
	private GameObject m_goCharaSkillPrefab;

	[SerializeField]
	private GameObject m_goEquipSkillPrefab;

	[SerializeField]
	private GameObject m_goBlazeArtsPrefab;

	[SerializeField]
	private EquipmentSkillTab[] m_asTab;

	[SerializeField]
	private UIScrollView m_sScroll;

	[SerializeField]
	private UITable m_sTable;

	private EEquipSkillTab m_eKind;

	private List<SkillCharaListItem> m_vCharaList;

	private List<EquipmentSkillEquipItem> m_vEquipList;

	private List<BlazeArtsListItem> m_vBlazeArtsList;

	private CharaDetail m_sChara;

	private bool m_bUpdateSelect;

	private float m_fDefaultCursor;

	private void Awake()
	{
	}

	public void Reset()
	{
	}

	public void Init(CharaDetail chara)
	{
	}

	private void OnEnable()
	{
	}

	public void SelectEquip(long target)
	{
	}

	public void OnChangeTab(EEquipSkillTab select)
	{
	}

	private void InitTab()
	{
	}

	private void InitChara()
	{
	}

	private void InitEquip()
	{
	}

	public void InitBlazeArts()
	{
	}
}
