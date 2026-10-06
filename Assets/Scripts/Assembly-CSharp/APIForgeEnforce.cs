using System;

public class APIForgeEnforce : MsgPackAPICommon<ForgeResultResponse>
{
	[Serializable]
	public class Request
	{
		[Serializable]
		public class Feed
		{
			public long ID;
		}

		public long TAR;

		public Feed[] EXP;

		public ResponseBase TUTO;
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
