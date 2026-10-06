public class APIComBannerInfo : MsgPackAPICommon<BannerInfoResponse>
{
	public class Request
	{
		public BannerCategory category;
	}

	private Request m_request;

	public BannerCategory Category
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
