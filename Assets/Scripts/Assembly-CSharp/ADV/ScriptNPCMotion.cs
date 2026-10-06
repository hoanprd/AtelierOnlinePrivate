using System.Collections.Generic;

namespace ADV
{
	public class ScriptNPCMotion : ScriptBase
	{
		private Game_Chara_MA_NPC m_sNPC;

		private bool m_bWait;

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
