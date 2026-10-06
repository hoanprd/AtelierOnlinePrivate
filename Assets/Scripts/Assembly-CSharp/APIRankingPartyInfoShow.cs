public class APIRankingPartyInfoShow : MsgPackAPICommon<RankingPartyInfoShowResponse>
{
	public class Request
	{
		public long TARGET_ID;

		public int FACTOR;
	}

	private Request m_sRequest;

	public long TargetID
	{
		set
		{
		}
	}

	public int Factor
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
