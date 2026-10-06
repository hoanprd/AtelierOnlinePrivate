using System.Collections.Generic;

public static class ProbabilityCalclator
{
	public static bool DetectFromPercent(int percent)
	{
		return false;
	}

	public static bool DetectFromPercent(float percent)
	{
		return false;
	}

	public static T DetermineFromDict<T>(Dictionary<T, int> targetDict)
	{
		return default(T);
	}

	public static T DetermineFromDict<T>(Dictionary<T, float> targetDict)
	{
		return default(T);
	}
}
