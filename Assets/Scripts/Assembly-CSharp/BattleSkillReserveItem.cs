using UnityEngine;

public class BattleSkillReserveItem : UIBase
{
	private MultiPlay_BattleData m_battleData;

	private MultiPlay_BattleMemberData m_memberData;

	private MultiPlay_BattleCharaData m_charaData;

	public GameObject nextObj;

	private bool isSkill;

	private int m_skillIndex;

	private int m_interruptIndex;

	public void Init(MultiPlay_BattleMemberData memberData, int skillListNo, int interruptIndex)
	{
	}

	public void Init(MultiPlay_BattleCharaData charaData, int df, int itemListId)
	{
	}

	public void Delete()
	{
	}

	public void OnFinished()
	{
	}

	public int GetMemberUniqueID()
	{
		return 0;
	}

	public int GetCharaID()
	{
		return 0;
	}

	public int GetSkillIndex()
	{
		return 0;
	}

	public int GetInterruptIndex()
	{
		return 0;
	}

	public bool IsSkill()
	{
		return false;
	}
}
