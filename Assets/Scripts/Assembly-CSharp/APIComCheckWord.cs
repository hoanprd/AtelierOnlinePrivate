using System;

public class APIComCheckWord : APISimple
{
	[Serializable]
	public class Request
	{
		public string CMT;
	}

	private Request m_sRequest;

	public string Comment
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
