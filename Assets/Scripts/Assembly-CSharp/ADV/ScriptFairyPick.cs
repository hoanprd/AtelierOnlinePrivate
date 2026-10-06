using Tutorial;

namespace ADV
{
	public class ScriptFairyPick : ScriptFairyBase
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
