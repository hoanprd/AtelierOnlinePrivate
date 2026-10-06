namespace MessagePack.Formatters
{
	public sealed class ShopComDetailInfoFormatter : IMessagePackFormatter<ShopComDetailInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ShopComDetailInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ShopComDetailInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
