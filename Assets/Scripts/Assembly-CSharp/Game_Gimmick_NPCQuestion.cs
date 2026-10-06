public class Game_Gimmick_NPCQuestion : Game_Gimmick_NPCBase
{
	public string GetTalkFile(QuestDetail quest)
	{
		return null;
	}

	public override EGimmickKind GetKind()
	{
		return EGimmickKind.eNONE;
	}
}
