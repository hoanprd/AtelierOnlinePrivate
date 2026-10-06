using System.Collections.Generic;
using QuestCondition;
using UnityEngine;

public class QuestStatusObject : MonoBehaviour
{
	public enum eConditionAction
	{
		Activate = 0,
		Deactivate = 1
	}

	private bool m_bActiveChild;

	public List<ConditionQuest> m_clsConditionQuestList;

	public eConditionAction m_eQuestAction;

	public eQuestMultiCondition m_eMultiConditionCheck;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public bool IsUpdateObject(List<QuestDetail> sDetailList)
	{
		return false;
	}

	public void UpdateObject(List<QuestDetail> sDetailList)
	{
	}
}
