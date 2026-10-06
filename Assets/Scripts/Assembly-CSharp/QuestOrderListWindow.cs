using System;
using System.Collections.Generic;
using UnityEngine;

public class QuestOrderListWindow : UIWindowBase
{
	[SerializeField]
	private UITable m_sGrid;

	[SerializeField]
	private UIScrollView m_sScroll;

	[SerializeField]
	private GameObject m_goMainBarPrefab;

	[SerializeField]
	private GameObject m_goSubBarPrefab;

	[SerializeField]
	private Transform m_trMainRoot;

	[SerializeField]
	private Transform m_trSideRoot;

	[SerializeField]
	private Transform m_trCharaRoot;

	[SerializeField]
	private Transform m_trTicketRoot;

	[SerializeField]
	private UIGrid m_sEventRoot;

	[SerializeField]
	private UIGrid m_sFreeRoot;

	[SerializeField]
	private Transform m_trTargetDetailRoot;

	[SerializeField]
	private Transform m_trDeliveryRoot;

	[SerializeField]
	private SpawnPrefabData m_sDetail;

	private bool m_bReadOnly;

	private List<QuestDetail> m_vUpdateList;

	private Action<List<QuestDetail>> m_sOnCloseEvent;

	private List<QuestDetail> m_vDispList;

	private QuestBar m_sSelectQuest;

	private QuestMainBar m_sSelectMainBar;

	protected void OnCloseDialog(EButtonKind button)
	{
	}

	protected override void OnCloseEnd()
	{
	}

	public void Init(List<QuestDetail> list, Action<List<QuestDetail>> onClose = null, bool readOnly = false, bool reset = true)
	{
	}

	private QuestBar CreateSubQuest(Transform root)
	{
		return null;
	}

	private void OnUpdateDetail(QuestDetail data)
	{
	}

	private void RemoveSelect()
	{
	}

	private void OnSelectMain(QuestMainBar target)
	{
	}

	private void OnSelect(QuestBar target)
	{
	}

	protected void OnTargetDetail(MasterQuestInfo master)
	{
	}

	public static QuestOrderListWindow Create(Transform root)
	{
		return null;
	}
}
