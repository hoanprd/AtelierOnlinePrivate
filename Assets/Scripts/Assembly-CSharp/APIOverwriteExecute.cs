public class APIOverwriteExecute : MsgPackAPICommon<OverwriteExecuteResponse>
{
	public class Request
	{
		public long BASE;

		public long MAT;
	}

	private Request m_Request;

	public long BASE
	{
		set
		{
		}
	}

	public long MAT
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
