public class APIHomeGrowFoodApply : MsgPackAPICommon<FoodResultResponse>
{
	public class Request
	{
		public int DF;

		public ItemID[] FOOD;
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

	public long[] Food
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
