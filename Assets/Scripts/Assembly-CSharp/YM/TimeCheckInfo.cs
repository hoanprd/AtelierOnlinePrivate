using System.Collections.Generic;

namespace YM
{
	internal class TimeCheckInfo
	{
		public readonly string name;

		private readonly int checkMs;

		public int procCnt;

		public int sumProcMs;

		public int maxProcMs;

		public int sumSendCnt;

		public int maxSendCntPerProc;

		public Dictionary<string, int> sumCheckCntMap;

		public TimeCheckInfo(int checkMs, string name)
		{
		}

		public string Make()
		{
			return null;
		}
	}
}
