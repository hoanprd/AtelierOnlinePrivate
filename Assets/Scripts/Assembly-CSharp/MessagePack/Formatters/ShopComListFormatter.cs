namespace MessagePack.Formatters
{
	public sealed class ShopComListFormatter : IMessagePackFormatter<ShopComList>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ShopComList value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ShopComList Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
