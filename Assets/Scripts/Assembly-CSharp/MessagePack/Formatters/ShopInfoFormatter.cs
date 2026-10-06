namespace MessagePack.Formatters
{
	public sealed class ShopInfoFormatter : IMessagePackFormatter<ShopInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ShopInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ShopInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
