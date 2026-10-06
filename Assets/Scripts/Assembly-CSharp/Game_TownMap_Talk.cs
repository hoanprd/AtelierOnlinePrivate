using System.Collections.Generic;
using UnityEngine;

public class Game_TownMap_Talk : MonoBehaviour
{
	public enum eTalkStep
	{
		First = 0,
		DefaultADV_Init = 1,
		DefaultADV_Wait = 2,
		SelectQuest_Init = 3,
		SelectQuest_Wait = 4,
		Adventure_Init = 5,
		Adventure_Wait = 6,
		Network_Init = 7,
		Network_Wait = 8,
		QuestShow_Init = 9,
		QuestShow_Wait = 10,
		Delivery_Init = 11,
		Delivery_Wait = 12,
		QuestDelivery_Init = 13,
		QuestDelivery_Wait = 14,
		DispAcheive_Init = 15,
		DispAcheive_Wait = 16,
		End = 17
	}

	private eTalkStep m_eTalkStep;

	private bool m_bUpdateOK;

	private Game_TownMap_Manager m_scrManager;

	private Game_PaperMap_SpotData m_scrSpot;

	private GameObject m_goWindowRoot;

	private bool m_bAPIEnd;

	private bool m_bAPIError;

	private List<int> m_iQuestDFList;

	private QuestDetail m_clsDetail;

	private MasterQuestInfo m_clsMaster;

	private EButtonKind m_eSelectResult;

	private bool m_bEndSelect;

	private InventoryList m_clsDeliInv;

	private QuestDeliveryManager m_scrDelivery;

	private bool m_bEndDelivery;

	private long[] m_lItemIdList;

	public void Init(Game_TownMap_Manager scrManager, Game_PaperMap_SpotData scrSpot, GameObject goWindowRoot)
	{
	}

	public bool IsEnd()
	{
		return false;
	}

	private void Update()
	{
	}

	private void OnEndSelect(EButtonKind eResult, int iQuestDF)
	{
	}

	private void OnAPITalk(QuestTalkResponse clsRes)
	{
	}

	public void OnSelectDeliveryItem(bool bExecute, List<InventoryInfo> clsSelectList)
	{
	}

	private void OnAPIQuestShow(QuestShowResponse clsRes)
	{
	}

	private void OnAPIDelivery(QuestDeliverResponse clsRes)
	{
	}
}
