using System.Collections.Generic;

namespace ADV
{
	public class ScriptFade : ScriptBase
	{
		public enum EParamKind
		{
			eONOFF = 0,
			eWAIT = 1,
			eDURATION = 2,
			COLOR = 3
		}

		private bool m_bFadeIn;

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
