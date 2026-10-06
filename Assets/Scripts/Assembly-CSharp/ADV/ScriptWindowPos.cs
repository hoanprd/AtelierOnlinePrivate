using System.Collections.Generic;

namespace ADV
{
	public class ScriptWindowPos : ScriptBase
	{
		private enum EParamKind
		{
			ePOS = 0
		}

		private int m_iPosKind;

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
