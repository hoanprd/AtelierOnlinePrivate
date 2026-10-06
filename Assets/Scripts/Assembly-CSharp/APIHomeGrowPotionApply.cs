public class APIHomeGrowPotionApply : MsgPackAPICommon<PotionResultResponse>
{
	public class Request
	{
		public int DF;

		public ItemID[] USE;
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

	public override byte[] GetAPI()
	{
		return null;
	}

	public override void PostProcess()
	{
	}
}
