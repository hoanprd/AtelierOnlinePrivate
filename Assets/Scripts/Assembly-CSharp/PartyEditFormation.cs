using System;
using System.Collections.Generic;
using UnityEngine;

public class PartyEditFormation : UIWrapListBase
{
	[Serializable]
	public class MemberList
	{
		public GameObject goPrefab;

		public UIGrid sGrid;

		public List<PartyEditFormationMember> vList;

		public void Create()
		{
		}

		public void Init(ESortKind sort)
		{
		}
	}

	public enum ESelectState
	{
		eSELECT_TARGET = 0,
		eSELECT_CHARA = 1,
		eDISABLE = 2
	}

	[SerializeField]
	private AnimationController m_sAnim;

	[SerializeField]
	private MemberList m_sPartyMember;

	[SerializeField]
	private UILabel[] m_asStateInfo;

	[SerializeField]
	private SpawnPrefabData m_sCharaDetail;

	private List<PartyMember> m_vMember;

	private PartyEditFormationMember m_sSetTarget;

	private int m_iChooseChara;

	[SerializeField]
	private SortStateInfo m_sSortState;

	[SerializeField]
	private Transform m_trSortWindowRoot;

	[SerializeField]
	private UILabel m_sFilterName;

	private SortFilterWindow m_sSortFilterWindow;

	private ESortKind m_eSortKind;

	private EFilterKind m_eFilterKind;

	private EOrder m_eOrderKind;

	private const string SORT_PREFIX = "FORMATION_";

	private void Awake()
	{
	}

	public void Bringin()
	{
	}

	public void Dismiss()
	{
	}

	public bool IsDissmissEnd()
	{
		return false;
	}

	private void Start()
	{
	}

	public void Init()
	{
	}

	private void OnDisable()
	{
	}

	private void InitParty()
	{
	}

	private void MakeDispList()
	{
	}

	protected override void InitItem(int index, GameObject target)
	{
	}

	private bool IsEnableSelect(int df)
	{
		return false;
	}

	private void UpdateTargetList()
	{
	}

	private void UpdateInfo()
	{
	}

	public void OnCharaDetail(PartyEditFormationChara target)
	{
	}

	public void OnChooseTargetChara(PartyEditFormationTarget target)
	{
	}

	public void OnChooseSetTarget(PartyEditFormationMember target)
	{
	}

	public void OnRemoveTarget(PartyEditFormationMember target)
	{
	}

	private void SwapMember(PartyEditFormationMember swap)
	{
	}

	private List<FormationInfo> GetFormation()
	{
		return null;
	}

	private bool UpdateMember()
	{
		return false;
	}

	private void PlayVoice(List<FormationInfo> next)
	{
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

	private List<PartyMember> GetFilter(ESubCategory weaponKind)
	{
		return null;
	}

	private int DefaultCompare(PartyMember a, PartyMember b)
	{
		return 0;
	}

	private int CompareHP(PartyMember a, PartyMember b)
	{
		return 0;
	}

	private int CompareATK(PartyMember a, PartyMember b)
	{
		return 0;
	}

	private int CompareATKM(PartyMember a, PartyMember b)
	{
		return 0;
	}

	private int CompareDEF(PartyMember a, PartyMember b)
	{
		return 0;
	}

	private int CompareDEFM(PartyMember a, PartyMember b)
	{
		return 0;
	}

	private int CompareSPD(PartyMember a, PartyMember b)
	{
		return 0;
	}

	private int CompareRarity(PartyMember a, PartyMember b)
	{
		return 0;
	}
}
