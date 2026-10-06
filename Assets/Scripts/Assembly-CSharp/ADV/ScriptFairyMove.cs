using Tutorial;

namespace ADV
{
	public class ScriptFairyMove : ScriptFairyBase
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
