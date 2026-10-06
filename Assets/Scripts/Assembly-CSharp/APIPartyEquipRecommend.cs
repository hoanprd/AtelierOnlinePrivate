public class APIPartyEquipRecommend : MsgPackAPICommon<EquipRecommendResponse>
{
	public class Request
	{
		public int DF;

		public int EQUIP_FRAME;

		public int STATUS_PRIORITY;
	}

	private Request m_sRequest;

	public int CharaID
	{
		set
		{
		}
	}

	public int EquipFrame
	{
		set
		{
		}
	}

	public int StatusPriority
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
