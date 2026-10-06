public class APIAlchemyAlter : MsgPackAPICommon<AlchemyAlterResponse>
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

		public ResponseBase TUTO;
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
