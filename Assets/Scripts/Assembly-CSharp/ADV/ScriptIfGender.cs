using System.Collections.Generic;

namespace ADV
{
	public class ScriptIfGender : ScriptBase
	{
		private int m_iGenderType;

		public override bool Init(List<string> param, bool skip)
		{
			return false;
		}

		public override int Next(ScriptInfo all, int startIndex, bool skip)
		{
			return 0;
		}
	}
}
