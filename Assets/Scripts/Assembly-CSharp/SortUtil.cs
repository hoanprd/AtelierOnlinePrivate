using System.Collections.Generic;

public static class SortUtil
{
	private static int DefaultSort(InventoryInfo a, InventoryInfo b)
	{
		return 0;
	}

	public static List<InventoryInfo> GetSortingConsumableItemList(ESortKind sort, List<InventoryInfo> list, EOrder order)
	{
		return null;
	}

	public static List<InventoryInfo> GetSortingItemList(ESortKind sort, List<InventoryInfo> list, EOrder order)
	{
		return null;
	}

	public static int CompareFire(InventoryInfo a, InventoryInfo b)
	{
		return 0;
	}

	public static int CompareWater(InventoryInfo a, InventoryInfo b)
	{
		return 0;
	}

	public static int CompareEarth(InventoryInfo a, InventoryInfo b)
	{
		return 0;
	}

	public static int CompareWind(InventoryInfo a, InventoryInfo b)
	{
		return 0;
	}

	public static int CompareDrak(InventoryInfo a, InventoryInfo b)
	{
		return 0;
	}

	public static int CompareLight(InventoryInfo a, InventoryInfo b)
	{
		return 0;
	}

	public static int CompareSpecialSkill(InventoryInfo a, InventoryInfo b)
	{
		return 0;
	}

	public static int CompareSpecialSkillLevel(InventoryInfo a, InventoryInfo b)
	{
		return 0;
	}

	public static int CompareCategory(InventoryInfo a, InventoryInfo b)
	{
		return 0;
	}

	public static int CompareQuality(InventoryInfo a, InventoryInfo b)
	{
		return 0;
	}

	public static int CompareLevel(InventoryInfo a, InventoryInfo b)
	{
		return 0;
	}

	public static int CompareATK(InventoryInfo a, InventoryInfo b)
	{
		return 0;
	}

	public static int CompareMATK(InventoryInfo a, InventoryInfo b)
	{
		return 0;
	}

	public static int CompareDEF(InventoryInfo a, InventoryInfo b)
	{
		return 0;
	}

	public static int CompareSpeed(InventoryInfo a, InventoryInfo b)
	{
		return 0;
	}

	public static int CompareRarity(InventoryInfo a, InventoryInfo b)
	{
		return 0;
	}

	public static int CompareName(InventoryInfo a, InventoryInfo b)
	{
		return 0;
	}

	public static int ComparePotion(InventoryInfo a, InventoryInfo b)
	{
		return 0;
	}

	public static List<InventoryInfo> GetFilteringItemList(EFilterKind filter, List<InventoryInfo> list)
	{
		return null;
	}

	public static void Load(string key, out ESortKind sort, out EFilterKind filter, out EOrder order, ESortKind sortDefault = ESortKind.eGET)
	{
		sort = default(ESortKind);
		filter = default(EFilterKind);
		order = default(EOrder);
	}

	public static void Save(string key, ESortKind sort, EFilterKind filter, EOrder order)
	{
	}
}
