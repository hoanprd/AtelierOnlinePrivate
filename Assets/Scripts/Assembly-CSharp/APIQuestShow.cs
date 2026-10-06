public class APIQuestShow : MsgPackAPICommon<QuestShowResponse>
{
	public class Request
	{
		public int DF;
	}

	private Request m_sRequest;

	public int QuestID
	{
		set
		{
		}
	}

	public override byte[] GetAPI()
	{
		return null;
	}

	public override void PostProcess()
	{
	}
}
