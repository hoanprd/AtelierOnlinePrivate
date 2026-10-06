using System;

public class APIRespireFusion : MsgPackAPICommon<RespireResultResponse>
{
	[Serializable]
	public class Request
	{
		[Serializable]
		public class Feed
		{
			public long ID;
		}

		public long BASE;

		public Feed[] MAT;
	}

	private Request m_sRequest;

	public long ID
	{
		set
		{
		}
	}

	public long[] Feeds
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
