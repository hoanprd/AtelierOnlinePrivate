public class APIExploreFieldEnter2 : MsgPackAPICommon<FieldEnter2Response>
{
	public class Request
	{
		public long RID;

		public int RNO;
	}

	private Request m_sRequest;

	public long RoomID
	{
		set
		{
		}
	}

	public int RoomIndex
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
