using System.Collections.Generic;

namespace ADV
{
	public class ScriptPrologue : ScriptBase
	{
		private static Prologue m_sInstance;

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
