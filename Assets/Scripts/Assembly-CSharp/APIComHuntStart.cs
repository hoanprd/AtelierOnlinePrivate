using System;

public class APIComHuntStart : MsgPackAPICommon<HuntStartResponse>
{
	[Serializable]
	public class Request
	{
		public int HUNTID;

		public int FID;

		public eHuntReturnType RTN;

		public int WTHDF;
	}

	private Request m_sRequest;

	private int m_iClearSec;

	private int m_iLeaderID;

	public int HuntID
	{
		set
		{
		}
	}

	public int FormID
	{
		set
		{
		}
	}

	public eHuntReturnType ReturnType
	{
		set
		{
		}
	}

	public int WealthDF
	{
		set
		{
		}
	}

	public int ClearSec
	{
		set
		{
		}
	}

	public int LeaderID
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
