namespace MessagePack.Formatters
{
	public sealed class ShopComInfo_PriceInfoFormatter : IMessagePackFormatter<ShopComInfo.PriceInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ShopComInfo.PriceInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ShopComInfo.PriceInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
