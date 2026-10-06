namespace MessagePack.Formatters
{
	public sealed class APIHomeShopGachaLot10_RequestFormatter : IMessagePackFormatter<APIHomeShopGachaLot10.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIHomeShopGachaLot10.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIHomeShopGachaLot10.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
