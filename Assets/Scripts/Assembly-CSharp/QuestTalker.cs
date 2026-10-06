using System.Collections.Generic;
using UnityEngine;

public class QuestTalker : MonoBehaviour
{
	public enum EStep
	{
		eNONE = 0,
		eSELECT = 1,
		eTALK = 2,
		eTALKEND = 3,
		eDELIVERY = 4,
		eACHIEVE = 5,
		eEND = 6
	}

	public enum ESubStep
	{
		eINIT = 0,
		eWAIT = 1,
		eNEXT = 2
	}

	private enum EDeliveryStep
	{
		eINIT = 0,
		eSHOW = 1,
		eSELECT_WINDOW = 2,
		eDELIVERY_WAIT = 3,
		eNEXT = 4
	}

	private EStep m_eStep;

	private int m_iSubStep;

	private bool m_bExit;

	private bool m_bComplete;

	private List<int> m_vQuestList;

	private QuestSelectWindow m_sQuestSelectWindow;

	private QuestDeliveryManager m_sDeliveryWindow;

	private int m_iTargetQuest;

	private QuestDetail m_sQuestInfo;

	private MasterQuestInfo m_sMaster;

	private List<InventoryInfo> m_vDeliveryCandidacy;

	public bool IsEnd
	{
		get
		{
			return false;
		}
	}

	public bool IsComplete
	{
		get
		{
			return false;
		}
	}

	private void OnDisable()
	{
	}

	public void Init(int quest)
	{
	}

	public void Init(List<int> questList)
	{
	}

	private void Update()
	{
	}

	private void NextStep(EStep step)
	{
	}

	private void SetQuest(int questDF)
	{
	}

	private EStep SelectQuest()
	{
		return EStep.eNONE;
	}

	private EStep PlayAdventure()
	{
		return EStep.eNONE;
	}

	private EStep Delivery()
	{
		return EStep.eNONE;
	}

	private void OnDeilveryComplete(QuestDeliverResponse res)
	{
	}

	private EStep SendTalk()
	{
		return EStep.eNONE;
	}

	private void OnTalkComplete(QuestTalkResponse res)
	{
	}

	private EStep Achieve()
	{
		return EStep.eNONE;
	}
}
