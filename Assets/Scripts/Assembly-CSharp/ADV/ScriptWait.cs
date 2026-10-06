using System.Collections.Generic;

namespace ADV
{
	public class ScriptWait : ScriptBase
	{
		protected float m_fWaitTime;

		private bool m_bSkipOK;

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
