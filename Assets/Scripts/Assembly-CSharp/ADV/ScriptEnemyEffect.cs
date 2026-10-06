using System.Collections.Generic;

namespace ADV
{
	public class ScriptEnemyEffect : ScriptBase
	{
		public override List<string> GetNeedAsset()
		{
			return null;
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
