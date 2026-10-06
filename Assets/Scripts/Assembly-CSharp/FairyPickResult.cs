using System;

[Serializable]
public class FairyPickResult
{
	[Serializable]
	public class GetItem
	{
		public int DF;

		public int QTY;

		public int TRT;
	}

	public int NO;

	public GetItem[] ITM;
}
