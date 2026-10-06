public class APIPartyEquipFavErase : MsgPackAPICommon<PartyEquipFavoEraseResponse>
{
	public class Request
	{
		public int DF;

		public int NO;

		public int KIND;
	}

	private Request m_sRequest;

	public int CharaID
	{
		set
		{
		}
	}

	public int NO
	{
		set
		{
		}
	}

	public int Kind
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
