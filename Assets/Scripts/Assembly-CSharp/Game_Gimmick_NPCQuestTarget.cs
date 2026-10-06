using System.Collections.Generic;

public class Game_Gimmick_NPCQuestTarget : Game_Gimmick_NPCBase
{
	private QuestNPC m_clsQuest;

	public int m_iDefNPCId;

	public string m_strDefTalkFile;

	public void SetDefault(int iDefNPCId, string strTalkFile)
	{
	}

	public override int GetQuestID()
	{
		return 0;
	}

	public string GetTalkFile(bool bDeafault, int iQuestDF = 0)
	{
		return null;
	}

	public List<int> GetQuestDFList()
	{
		return null;
	}

	public bool IsQuest()
	{
		return false;
	}

	public override void UpdateSpotInfo()
	{
	}

	public override EGimmickKind GetKind()
	{
		return EGimmickKind.eNONE;
	}
}
