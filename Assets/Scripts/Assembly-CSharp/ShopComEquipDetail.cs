using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ShopComEquipDetail : ShopComDetailBase
{
	private class PickupItemData
	{
		public bool bAll;

		public ShopComDetail.Item sData;

		public PickupItemData(ShopComDetail.Item item)
		{
		}

		public PickupItemData()
		{
		}
	}

	[SerializeField]
	private LimitBreakMark m_sLimitbreakMark;

	[SerializeField]
	private UILabel m_sName;

	[SerializeField]
	private GameObject m_goEquipInfoRoot;

	[SerializeField]
	private EquipAllStatus m_sStatus;

	[SerializeField]
	private ShopModel m_sModel;

	[SerializeField]
	private UIPageGrid m_sPage;

	[SerializeField]
	private GameObject m_sNextPageCollider;

	private float m_fWaitTime;

	private List<PickupItemData> m_vPageList;

	private int m_iPage;

	private bool m_bNextDir;

	protected override void Awake()
	{
	}

	private void OnDetail(EquipSkillItem target)
	{
	}

	[DebuggerHidden]
	private IEnumerator DispSkillDetail(DialogActiveSkill diag)
	{
		return null;
	}

	public override void Init()
	{
	}

	public override void Init(EShopComKind kind, ShopComItem detail)
	{
	}

	public void OnNext(bool next)
	{
	}

	protected override void Update()
	{
	}

	private void InitNextInfo()
	{
	}

	private void UpdatePage(ShopComDetail.Item item)
	{
	}
}
