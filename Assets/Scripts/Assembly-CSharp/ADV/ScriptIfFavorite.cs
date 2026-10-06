using System.Collections.Generic;

namespace ADV
{
	public class ScriptIfFavorite : ScriptBase
	{
		private int m_iTargetChara;

		private int m_iThreshiold;

		public override bool Init(List<string> param, bool skip)
		{
			return false;
		}

		public override bool Exec(bool tap, bool skip)
		{
			return false;
		}

		public override int Next(ScriptInfo all, int startIndex, bool skip)
		{
			return 0;
		}
	}
}
