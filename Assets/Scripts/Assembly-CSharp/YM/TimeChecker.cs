using System.Collections.Generic;

namespace YM
{
	public class TimeChecker
	{
		private const int CHECK_MS = 1000;

		private const int PRINT_CNT = 10;

		private int startTime;

		private int checkedTime;

		private int trySendCnt;

		private readonly Dictionary<string, int> trySendCntMap;

		private TimeCheckInfo checkInfo;

		private readonly List<TimeCheckInfo> infoList;

		public TimeChecker(string name)
		{
		}

		public static int NOW()
		{
			return 0;
		}

		public void Start()
		{
		}

		public void CheckSend(string name)
		{
		}

		public void Check(string name)
		{
		}

		public void End()
		{
		}

		private void _print()
		{
		}
	}
}
