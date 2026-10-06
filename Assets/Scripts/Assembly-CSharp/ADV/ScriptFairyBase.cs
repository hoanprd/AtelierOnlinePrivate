using System.Collections.Generic;
using Tutorial;

namespace ADV
{
	public abstract class ScriptFairyBase : ScriptBase
	{
		protected enum EParamKind
		{
			eWAIT = 0
		}

		protected Data m_sCommand;

		protected abstract eExecKind CommandKind { get; }

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
