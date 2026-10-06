using System.Collections.Generic;

namespace ADV
{
	public class ScriptItemWindow : ScriptBase
	{
		private bool m_bIn;

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
