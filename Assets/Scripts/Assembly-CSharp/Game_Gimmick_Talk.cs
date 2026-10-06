using UnityEngine;

public class Game_Gimmick_Talk : Game_Gimmick_Base
{
	private int m_iQuestId;

	private Game_Chara_MA_NPC m_sNPC;

	private Vector3 m_vDefaultRotation;

	protected Game_Animal_BaseFader m_myAnimalBase;

	public Vector3 GetDefaultRotation()
	{
		return default(Vector3);
	}

	public Game_Chara_MA_NPC GetNPC()
	{
		return null;
	}

	public void Init(Game_Chara_MA_NPC npc, int npcID, int questID, bool[] moveTimeArray, bool[] moveWeatherArray)
	{
	}

	public string GetTalkFile(QuestDetail quest)
	{
		return null;
	}

	public int GetQuestID()
	{
		return 0;
	}

	public override EGimmickKind GetKind()
	{
		return EGimmickKind.eNONE;
	}

	public override bool IsEnable()
	{
		return false;
	}
}
