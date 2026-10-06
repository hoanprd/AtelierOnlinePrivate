using System.Collections.Generic;

public static class GachaDirUtil
{
	private static readonly Dictionary<EQuality, EGachaResultKind> Quality_GachaResultMapForNonCertainItem;

	public static int GetUzuKind(EGachaResultKind kind)
	{
		return 0;
	}

	public static int GetEffectKind(ShopGachaLot.LotResult result)
	{
		return 0;
	}

	public static EGachaResultKind GetResultKind(ShopGachaLot.LotResult result)
	{
		return EGachaResultKind.eNORMAL;
	}

	public static EGachaResultKind GetResultKindNonCertain(ShopGachaLot.LotResult result)
	{
		return EGachaResultKind.eNORMAL;
	}
}
