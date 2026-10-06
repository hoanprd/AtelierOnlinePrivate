public class APIHomePartyEquipSubChoose : APISimple
{
	public class Request
	{
		public int DF;

		public SubEquip[] SUB;
	}

	private Request m_sRequest;

	public int CharaID
	{
		set
		{
		}
	}

	public SubEquip[] Sub
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
