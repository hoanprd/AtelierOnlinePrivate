public class APIExploreFieldGateStamp : APISimple
{
	public class Request
	{
		public int GT;
	}

	private Request m_sRequest;

	public int GateID
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
