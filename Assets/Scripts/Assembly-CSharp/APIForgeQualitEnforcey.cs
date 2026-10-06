using System;

public class APIForgeQualitEnforcey : MsgPackAPICommon<ForgeResultResponse>
{
	[Serializable]
	public class Request
	{
		public long ID;
	}

	private Request m_sRequest;

	public long ID
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
