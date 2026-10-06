using Tutorial;

namespace ADV
{
	public class ScriptFairyMoveObj : ScriptFairyBase
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
