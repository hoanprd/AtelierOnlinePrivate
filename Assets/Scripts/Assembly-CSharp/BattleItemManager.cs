using System.Collections.Generic;
using UnityEngine;

public class BattleItemManager : MonoBehaviour
{
	private Dictionary<int, BattleItemListItem> ItemList;

	public void Init(BattleStart startResponse, ResponseDataCommon commonResponse)
	{
	}

	public void Init(BattleJoin joinResponse, ResponseDataCommon commonResponse)
	{
	}

	private void Update()
	{
	}

	public int GetList(int number)
	{
		return 0;
	}

	public int GetDF(int number)
	{
		return 0;
	}

	public int GetNO(int df)
	{
		return 0;
	}

	public void Delete()
	{
	}

	public void Use(int df, bool costdown, bool gaugeTakeOver, long itemID)
	{
	}

	public void UseInterrupt(int df, bool costdown, long itemID)
	{
	}

	public void Cancel(int number)
	{
	}

	public void Continue()
	{
	}

	public void SetGaugePause(bool pause)
	{
	}

	public void ChangeStep(BattleItemListItem.EItemGaugeStep step, int df)
	{
	}

	public void Fill(int itemDF)
	{
	}
}
