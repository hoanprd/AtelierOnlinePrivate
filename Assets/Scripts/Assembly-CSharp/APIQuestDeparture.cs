public class APIQuestDeparture : APISimple
{
	public class Request
	{
		public int DF;

		public ResponseBase TUTO;
	}

	private Request m_sRequest;

	public int QuestID
	{
		set
		{
		}
	}

	public int TutoDf
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
