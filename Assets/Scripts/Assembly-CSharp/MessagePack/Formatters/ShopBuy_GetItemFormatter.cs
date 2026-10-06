namespace MessagePack.Formatters
{
	public sealed class ShopBuy_GetItemFormatter : IMessagePackFormatter<ShopBuy.GetItem>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ShopBuy.GetItem value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ShopBuy.GetItem Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
