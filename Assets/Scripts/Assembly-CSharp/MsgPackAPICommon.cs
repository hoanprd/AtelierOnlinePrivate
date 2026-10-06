public abstract class MsgPackAPICommon<T> : APIBase where T : ResponseDataCommon
{
	public MsgPackResponse<T> m_sCallback;

	public T m_sResponse;

	public ResponseDataCommon m_sCommon;

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
