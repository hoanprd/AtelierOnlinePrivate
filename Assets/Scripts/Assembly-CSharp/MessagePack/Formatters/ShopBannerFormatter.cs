namespace MessagePack.Formatters
{
	public sealed class ShopBannerFormatter : IMessagePackFormatter<ShopBanner>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ShopBanner value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ShopBanner Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
