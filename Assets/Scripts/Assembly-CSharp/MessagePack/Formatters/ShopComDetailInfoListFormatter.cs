namespace MessagePack.Formatters
{
	public sealed class ShopComDetailInfoListFormatter : IMessagePackFormatter<ShopComDetailInfoList>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ShopComDetailInfoList value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ShopComDetailInfoList Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
