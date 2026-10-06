using Tutorial;

namespace ADV
{
	public class ScriptFairyAppear : ScriptFairyBase
	{
		protected override eExecKind CommandKind
		{
			get
			{
				return eExecKind.ADV;
			}
		}
	}
}
