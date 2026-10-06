using System;

public class APIHomePresentReceive : MsgPackAPICommon<PresentReceiveResponse>
{
	[Serializable]
	public class Request
	{
		[Serializable]
		public class IDData
		{
			public long ID;
		}

		public IDData[] LIST;
	}

	private Request m_sRequest;

	public long[] IDList
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
