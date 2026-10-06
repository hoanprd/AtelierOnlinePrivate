using System.Collections.Generic;
using UnityEngine;

public class BattleHaveItemListItem : MonoBehaviour
{
	private MasterItem m_master;

	private int m_count;

	private List<InventoryInfo> m_RckList;

	private MultiPlay_BattleCharaData m_battleCharaData;

	public void Init(ResponseDataCommon common, MasterItem master)
	{
	}

	public void Init(int category)
	{
	}

	public void Use(long itemID)
	{
	}

	private void Update()
	{
	}

	public int GetDF()
	{
		return 0;
	}

	public void Fill()
	{
	}

	private IEnumerable<MultiPlay_InventoryInfo> GetUsableItem()
	{
		return null;
	}
}
