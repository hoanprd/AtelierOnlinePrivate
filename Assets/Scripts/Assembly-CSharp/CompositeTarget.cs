using System;

[Serializable]
public class CompositeTarget : InventoryInfo
{
	[Serializable]
	public class LevelInfo
	{
		public int MIN_LV;

		public int MAX_LV;
	}

	public LevelInfo LV_LIMIT;

	public Formula EXP_COEF;

	public LevelInfo LV_LIMIT_FORGE_QTY;

	public Formula EXP_COEF_FORGE_QTY;
}
