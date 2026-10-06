using System.Collections.Generic;

namespace ADV
{
	public class ScriptEnemyMotion : ScriptBase
	{
		private Game_Enemy_ADV m_sEnemy;

		private BattleCharaData.eActionKind m_eMotion;

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
