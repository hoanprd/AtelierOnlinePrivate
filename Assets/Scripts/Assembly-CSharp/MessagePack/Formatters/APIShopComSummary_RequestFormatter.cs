namespace MessagePack.Formatters
{
	public sealed class APIShopComSummary_RequestFormatter : IMessagePackFormatter<APIShopComSummary.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIShopComSummary.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIShopComSummary.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
