public abstract class APISimple : APIBase
{
	public Response m_sCallback;

	public ResponseDataCommon m_sResponse;

	public override string Analysis(byte[] msgpack)
	{
		return null;
	}

	public override void Notify()
	{
	}

	public override void RegistError(string msg)
	{
	}

	public override void RegistError()
	{
	}

	public override ResponseDataCommon GetCommonData()
	{
		return null;
	}
}
