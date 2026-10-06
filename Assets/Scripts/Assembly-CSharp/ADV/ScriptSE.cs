using System.Collections.Generic;

namespace ADV
{
	public class ScriptSE : ScriptBase
	{
		private enum EParamKind
		{
			eID = 0,
			eWAIT = 1
		}

		private Sound_OneShot m_sPlaySound;

		private bool m_bWait;

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
