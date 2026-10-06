namespace MessagePack.Formatters
{
	public sealed class APIHomeShopGachaLot_RequestFormatter : IMessagePackFormatter<APIHomeShopGachaLot.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIHomeShopGachaLot.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIHomeShopGachaLot.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
