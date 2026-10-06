using System.Collections.Generic;

namespace ADV
{
	public class ScriptBackgroundShake : ScriptBase
	{
		private enum EParamKind
		{
			eDURATION = 0,
			ePOWER = 1,
			eWAIT = 2
		}

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
