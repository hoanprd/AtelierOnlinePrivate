using System.Collections.Generic;

namespace ADV
{
	public class ScriptEnemyMove : ScriptBase
	{
		private Game_Enemy_ADV m_sEnemy;

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
