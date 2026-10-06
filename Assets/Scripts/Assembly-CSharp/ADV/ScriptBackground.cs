using System.Collections.Generic;

namespace ADV
{
	public class ScriptBackground : ScriptBase
	{
		private enum EParamKind
		{
			ePICTURE_ID = 0,
			eNAME = 1,
			eNAME_SUB = 2
		}

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
