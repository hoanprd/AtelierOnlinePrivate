namespace MessagePack.Formatters
{
	public sealed class APIComBannerInfo_RequestFormatter : IMessagePackFormatter<APIComBannerInfo.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIComBannerInfo.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIComBannerInfo.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
