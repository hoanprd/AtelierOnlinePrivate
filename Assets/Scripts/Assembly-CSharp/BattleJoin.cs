using System;

[Serializable]
public class BattleJoin
{
	public BattleEnemyInfo[] ENM;

	public BattlePlayerInfo[] PT;

	public BattlePlayerInfo[] PT_HOST;

	public ManualItemInfo[] PT_ITEM;

	public AIItemInfo[] PT_AI;
}
