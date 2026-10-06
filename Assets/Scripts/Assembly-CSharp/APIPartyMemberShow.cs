public class APIPartyMemberShow : MsgPackAPICommon<PartyMemberShowResponse>
{
	public class Request
	{
		public int DF;
	}

	private Request m_sRequest;

	public int CharaID
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
