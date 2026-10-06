public class APIExploreVillageInfo : MsgPackAPICommon<VillageInfoResponse>
{
	public class Request
	{
		public int DF;
	}

	private Request m_sRequest;

	public int TownID
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
