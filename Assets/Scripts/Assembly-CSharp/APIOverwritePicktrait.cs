using System;

public class APIOverwritePicktrait : MsgPackAPICommon<PickTraitResponse>
{
	[Serializable]
	public class Request
	{
		public long ID;
	}

	private Request m_Request;

	public long ID
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
