public class APIExploreVillageHeal : MsgPackAPICommon<VillageHealResponse>
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
