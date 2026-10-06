using System;

[Serializable]
public class RespireResult
{
	[Serializable]
	public class ForgeResult
	{
		public int SUC;

		public int MN;

		public ForgeResultEXP BF;

		public ForgeResultEXP AF;
	}

	[Serializable]
	public class ForgeResultEXP
	{
		public int LV;

		public int EXP;

		public int LVCAP;

		public int LVBRK;

		public int QTEXP;

		public int QTY;
	}

	[Serializable]
	public class ResultItem : InventoryDetail
	{
	}

	public ResultItem GET;

	public ForgeResult INFO;
}
