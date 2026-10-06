namespace MessagePack.Formatters
{
	public sealed class APIHomeShopGachaLotP_RequestFormatter : IMessagePackFormatter<APIHomeShopGachaLotP.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIHomeShopGachaLotP.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIHomeShopGachaLotP.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
