using Tutorial;

namespace ADV
{
	public class ScriptFairyRot : ScriptFairyBase
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
