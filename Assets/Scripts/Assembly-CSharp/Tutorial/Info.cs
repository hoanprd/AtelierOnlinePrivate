using System.Collections.Generic;

namespace Tutorial
{
	public class Info
	{
		public int iDF { get; private set; }

		public string strAsset { get; private set; }

		public string strName { get; private set; }

		public bool bSend { get; private set; }

		public List<eTutorial> eSkipList { get; private set; }

		public Info(int iDF, bool bSend, string strAsset, string strSkipList)
		{
		}
	}
}
