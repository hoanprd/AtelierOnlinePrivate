namespace MessagePack.Formatters
{
	public sealed class APIShopComBuy_RequestFormatter : IMessagePackFormatter<APIShopComBuy.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIShopComBuy.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIShopComBuy.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
