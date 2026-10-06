using System.Collections.Generic;
using UnityEngine;

public class BattleHaveItemManager : MonoBehaviour
{
	private MultiPlay_CharaData m_charaData;

	private List<BattleHaveItemListItem> m_HaveItemList;

	private ResponseDataCommon m_startCommon;

	public void Init(BattleStart res, ResponseDataCommon common)
	{
	}

	public void Init(BattleJoin res, ResponseDataCommon common)
	{
	}

	private void SerchIcon(AIItemInfo[] itemarray, ResponseDataCommon common, int category)
	{
	}

	private void AddIcon(ResponseDataCommon common, MasterItem master, int category = 0)
	{
	}

	public void Delete()
	{
	}

	public void Use(int df, long itemID)
	{
	}

	public void Fill(int itemDF)
	{
	}
}
