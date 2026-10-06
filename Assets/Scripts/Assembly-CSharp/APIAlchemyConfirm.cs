public class APIAlchemyConfirm : MsgPackAPICommon<AlchemyConfirmResponse>
{
	public class Request
	{
		public class UseItem
		{
			public long ID;
		}

		public int DF;

		public UseItem[] MAT;

		public long FREE;
	}

	private Request m_sRequest;

	public int RecipeID
	{
		set
		{
		}
	}

	public long Free
	{
		set
		{
		}
	}

	public long[] Materials
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
