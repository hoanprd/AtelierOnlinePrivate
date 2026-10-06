using System.Collections.Generic;

namespace ADV
{
	public class ScriptSkipStop : ScriptBase
	{
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
