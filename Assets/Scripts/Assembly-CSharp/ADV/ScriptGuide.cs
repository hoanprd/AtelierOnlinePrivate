using System.Collections.Generic;

namespace ADV
{
	public class ScriptGuide : ScriptBase
	{
		private enum EParamKind
		{
			eCONTENT = 0,
			eWAIT = 1,
			eSKIP = 2
		}

		private string m_sContent;

		private bool m_bWait;

		private bool m_bSkipOK;

		private bool m_bSkipLog;

		private bool m_bWaitFade;

		public override bool Init(List<string> param, bool skip)
		{
			return false;
		}

		public override bool Exec(bool tap, bool skip)
		{
			return false;
		}
	}
}
