namespace MessagePack.Formatters
{
	public sealed class APIHomeShopGachaShow_RequestFormatter : IMessagePackFormatter<APIHomeShopGachaShow.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIHomeShopGachaShow.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIHomeShopGachaShow.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
