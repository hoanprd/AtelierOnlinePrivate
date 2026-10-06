public class Game_Enemy_MA_AI_Wander : Game_Enemy_MA_AI_Base
{
	protected override eFEnemyAIState AI_Init()
	{
		return eFEnemyAIState.Init;
	}

	protected override eFEnemyAIState AI_Wait()
	{
		return eFEnemyAIState.Init;
	}

	protected override eFEnemyAIState AI_FreeMove()
	{
		return eFEnemyAIState.Init;
	}
}
