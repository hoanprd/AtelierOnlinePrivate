using System.Collections.Generic;

namespace ADV
{
	public class ScriptEmoticon : ScriptBase
	{
		public enum EParamKind
		{
			eKIND = 0,
			eWAIT = 1
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
