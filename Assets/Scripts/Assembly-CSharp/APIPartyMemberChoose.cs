using System;

public class APIPartyMemberChoose : APISimple
{
	[Serializable]
	public class Request
	{
		public FormationInfo[] PT;
	}

	private Request m_sRequest;

	public FormationInfo[] Formation
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
