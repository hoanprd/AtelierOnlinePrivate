public class APIPartyEquipInfo : APISimple
{
	public class Request
	{
		public int DF;

		public int CT;
	}

	private Request m_sRequest;

	public int CharaID
	{
		set
		{
		}
	}

	public int Category
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
