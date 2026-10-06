using System.Collections.Generic;
using UnityEngine;

public class BattleSkillReserveManager : MonoBehaviour
{
	public int SkillCount;

	public int ItemCount;

	private MultiPlay_BattleData m_battleData;

	private List<GameObject> ReserveUiList;

	private int count;

	public void Init()
	{
	}

	private void NextMarkUpdate()
	{
	}

	public void AddReserveSkill(MultiPlay_BattleMemberData memberData, int skillListNo, int interruptIndex)
	{
	}

	public void AddReserveItem(MultiPlay_BattleCharaData charaData, int df, int itemListId)
	{
	}

	public void CancelReserveSkill(MultiPlay_BattleMemberData memberData, int skillIndex, int interruptIndex)
	{
	}

	public void CancelReserveItem(MultiPlay_BattleCharaData cahraData)
	{
	}

	public void DeleteReserve()
	{
	}

	public void DeleteAllReserve()
	{
	}
}
