namespace MessagePack.Formatters
{
	public sealed class ShopComInfoFormatter : IMessagePackFormatter<ShopComInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ShopComInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ShopComInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
