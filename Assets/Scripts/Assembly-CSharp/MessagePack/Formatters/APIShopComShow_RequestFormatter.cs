namespace MessagePack.Formatters
{
	public sealed class APIShopComShow_RequestFormatter : IMessagePackFormatter<APIShopComShow.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIShopComShow.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIShopComShow.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
