using System.Collections.Generic;

namespace ADV
{
	public class ScriptPicture : ScriptBase
	{
		private enum EParamKind
		{
			ePATH = 0
		}

		private string m_sPath;

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
