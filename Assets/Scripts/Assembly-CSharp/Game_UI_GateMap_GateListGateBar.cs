using UnityEngine;

public class Game_UI_GateMap_GateListGateBar : Game_UI_GateMap_GateButton_Base
{
	[SerializeField]
	private UILabel m_scrGateName;

	[SerializeField]
	private QuestCategoryMark m_scrQuestMark;

	public override void SetInfo(int iArea, int iStage, int iSpawnNo, string strGateName)
	{
	}

	public void SetActiveQuestMark(bool bActive)
	{
	}

	public void SetQuestInfo(MasterQuestInfo clsQuest)
	{
	}
}
