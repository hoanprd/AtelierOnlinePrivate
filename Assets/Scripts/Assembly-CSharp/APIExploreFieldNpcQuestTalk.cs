public class APIExploreFieldNpcQuestTalk : MsgPackAPICommon<QuestTalkResponse>
{
	public class Request
	{
		public int DF;
	}

	private Request m_sRequest;

	public int DF
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
