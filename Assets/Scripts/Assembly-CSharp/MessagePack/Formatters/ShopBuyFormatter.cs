namespace MessagePack.Formatters
{
	public sealed class ShopBuyFormatter : IMessagePackFormatter<ShopBuy>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ShopBuy value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ShopBuy Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
