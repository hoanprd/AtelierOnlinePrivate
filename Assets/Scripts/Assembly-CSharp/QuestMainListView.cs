using System.Collections.Generic;
using UnityEngine;

public class QuestMainListView : UIListViewBase<QuestMainBar>
{
	[SerializeField]
	private GameObject m_goNoneText;

	[SerializeField]
	private GameObject m_goEnableQuestNoneText;

	[SerializeField]
	private SpawnPrefabData m_sRewardWindow;

	private QuestDetailWindow m_sDetail;

	private List<QuestDetail> m_vList;

	private List<MasterQuestInfo> m_vMasterList;

	private DegreeMissionInfo[] m_asMissionDegreeList;

	private QuestMainBar m_sSelectQuest;

	private int m_iSelectID;

	public override QuestMainBar GetObject()
	{
		return null;
	}

	public void UpdateInfo()
	{
	}

	public void Init(List<QuestDetail> list, DegreeMissionInfo[] degree)
	{
	}

	public void OnRewardList(QuestMainBar target)
	{
	}

	public void OnSelectQuest(QuestMainBar target)
	{
	}

	private QuestDetailWindow LoadDetailWindow()
	{
		return null;
	}
}
