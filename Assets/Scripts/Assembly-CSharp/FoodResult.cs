using System;

[Serializable]
public class FoodResult : FoodInfo
{
	[Serializable]
	public class Result
	{
		public int SUC;
	}

	public Result INFO;

	public CharaDetail CH;
}
