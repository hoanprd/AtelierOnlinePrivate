using System;

public class APIQuestGiveup : MsgPackAPICommon<QuestGiveupResponse>
{
	[Serializable]
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
}
