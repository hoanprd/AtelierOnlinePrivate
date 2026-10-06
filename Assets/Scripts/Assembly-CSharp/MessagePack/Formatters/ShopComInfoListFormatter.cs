namespace MessagePack.Formatters
{
	public sealed class ShopComInfoListFormatter : IMessagePackFormatter<ShopComInfoList>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ShopComInfoList value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ShopComInfoList Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
