using System.Collections.Generic;

namespace ADV
{
	public class ScriptSkip : ScriptBase
	{
		protected EOrderType m_eTargetOrder;

		private void Awake()
		{
		}

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
