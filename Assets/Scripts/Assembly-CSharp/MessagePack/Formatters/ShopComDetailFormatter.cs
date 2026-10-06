namespace MessagePack.Formatters
{
	public sealed class ShopComDetailFormatter : IMessagePackFormatter<ShopComDetail>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ShopComDetail value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ShopComDetail Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
