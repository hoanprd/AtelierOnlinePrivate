public class APIExploreFieldReload : MsgPackAPICommon<FieldReloadResponse>
{
	public class Request
	{
		public long RID;
	}

	private Request m_sRequest;

	public long RoomID
	{
		set
		{
		}
	}

	public override byte[] GetAPI()
	{
		return null;
	}

	public override string Analysis(byte[] msgpack)
	{
		return null;
	}

	public override void PostProcess()
	{
	}
}
