public class APIHomeGrowBlazeartsmateriaApply : MsgPackAPICommon<BlazeMateriaResultResponse>
{
	public class Request
	{
		public int DF;

		public ItemID[] USE;

		public int BA;
	}

	public class ItemID
	{
		public long ID;
	}

	private Request m_sRequest;

	public int CharaID
	{
		set
		{
		}
	}

	public long[] UseItem
	{
		set
		{
		}
	}

	public int BlazeArtsID
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
