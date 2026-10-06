public class APIPartyItemChoose : MsgPackAPICommon<PartyItemChooseResponse>
{
	public class Request
	{
		public PartyItemData[] ITEM;

		public PartyItemData[] AI;

		public ResponseBase TUTO;
	}

	private Request m_sRequest;

	public PartyItemData[] Manual
	{
		set
		{
		}
	}

	public PartyItemData[] Auto
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
