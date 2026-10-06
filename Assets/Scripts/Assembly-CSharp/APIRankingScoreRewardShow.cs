public class APIRankingScoreRewardShow : MsgPackAPICommon<RankingScoreRewardShowResponse>
{
	public class Request
	{
		public int TYPE;

		public int CYC;
	}

	private Request m_sRequest;

	public int Cycle
	{
		set
		{
		}
	}

	public int TYPE
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
