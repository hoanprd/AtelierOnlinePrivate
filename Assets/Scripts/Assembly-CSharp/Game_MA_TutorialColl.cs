using System.Collections.Generic;
using QuestCondition;
using Tutorial;

public class Game_MA_TutorialColl : Game_MA_HitColl_Base
{
	public enum eConditionAction
	{
		Enable = 0,
		Disable = 1
	}

	public enum eItemCondition
	{
		None = -1,
		HealingSalve = 0,
		EnumMax = 1
	}

	private static readonly EItemDF[] sr_ConditionItemDF;

	public eTutorialCondition m_eTutorialKind;

	public eTutorialCondition m_eConditionPrev;

	public eTutorialCondition m_eConditionNext;

	public eItemCondition m_eConditionItem;

	public List<ConditionQuest> m_clsConditionQuestList;

	public eConditionAction m_eQuestAction;

	public eQuestMultiCondition m_eMultiConditionCheck;

	protected override void HitPlayer(Game_Chara_MA_Player clsPlayer)
	{
	}

	private void ExecCallBack(eTutorial eClear, bool bSuccess, bool bSkip)
	{
	}

	private bool IsOutofConditionRange(eTutorialCondition eCondition)
	{
		return false;
	}

	private bool IsOutofConditionRange(eItemCondition eCondition)
	{
		return false;
	}
}
