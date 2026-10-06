using System.Collections.Generic;

namespace ADV
{
	public class ScriptEffectObj : ScriptBase
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
