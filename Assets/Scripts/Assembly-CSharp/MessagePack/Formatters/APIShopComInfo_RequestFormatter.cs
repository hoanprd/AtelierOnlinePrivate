namespace MessagePack.Formatters
{
	public sealed class APIShopComInfo_RequestFormatter : IMessagePackFormatter<APIShopComInfo.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIShopComInfo.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIShopComInfo.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
