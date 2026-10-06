using System.Collections.Generic;

public class OverwriteEquipCostInfo
{
	private Dictionary<string, List<AlchemyOverwritePickTraitResponse.WealthAmount>> m_mWthCosts;

	private List<int> m_vEnabledTrt;

	public void Init(AlchemyOverwritePickTraitResponse CostInfo = null)
	{
	}

	public int GetEtherCost(long itemID)
	{
		return 0;
	}

	public int GetFairySpoonCost(long itemID)
	{
		return 0;
	}

	private int ReferDictionary(long itemID, EWealthKind type)
	{
		return 0;
	}

	public bool GetEnabledTrt(int trait)
	{
		return false;
	}

	public Dictionary<long, int> ToFairySpoonCostDictionary()
	{
		return null;
	}
}
