public class Game_Enemy_MA_AI_Escape : Game_Enemy_MA_AI_Base
{
	protected override eFEnemyAIState AI_Init()
	{
		return eFEnemyAIState.Init;
	}

	protected override eFEnemyAIState AI_FreeMove()
	{
		return eFEnemyAIState.Init;
	}

	protected override eFEnemyAIState AI_Discovery()
	{
		return eFEnemyAIState.Init;
	}
}
