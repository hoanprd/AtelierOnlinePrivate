using System.Collections.Generic;
using UnityEngine;

public class MasterAdventBattle : ScriptableObject
{
	public List<AdventEvent> RankingList;

	public AdventEvent FindAdventEvent(int _id)
	{
		return null;
	}

	public List<AdventBattleScore> FindAdventBattleScore(int _id, int _df, EBattleScoreKind _kind = EBattleScoreKind.eNONE)
	{
		return null;
	}
}
