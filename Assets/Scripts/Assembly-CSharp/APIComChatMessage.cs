public class APIComChatMessage : APISimple
{
	public class Request
	{
		public string MSG;
	}

	private Request m_sRequest;

	public string MSG
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
