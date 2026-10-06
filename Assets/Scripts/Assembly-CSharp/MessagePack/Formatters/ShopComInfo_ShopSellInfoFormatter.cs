namespace MessagePack.Formatters
{
	public sealed class ShopComInfo_ShopSellInfoFormatter : IMessagePackFormatter<ShopComInfo.ShopSellInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ShopComInfo.ShopSellInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ShopComInfo.ShopSellInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
