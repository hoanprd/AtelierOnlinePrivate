using System;

public class APIHomeSalonChoose : MsgPackAPICommon<SalonChooseResponse>
{
	[Serializable]
	public class Request
	{
		public int DF;

		public AppearanceInfo MAKE;
	}

	private Request m_sRequest;

	public int CharacterID
	{
		set
		{
		}
	}

	public AppearanceInfo Appearance
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
