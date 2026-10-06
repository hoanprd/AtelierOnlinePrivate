public class APIExtraQuestFinish : APISimple
{
	public class Request
	{
		public int QUEST_DF;

		public int KEY_CHARA_NUM;
	}

	private Request m_sRequest;

	public int QuestDf
	{
		set
		{
		}
	}

	public int KeyCharaNum
	{
		set
		{
		}
	}

	public override byte[] GetAPI()
	{
		return null;
	}
}
