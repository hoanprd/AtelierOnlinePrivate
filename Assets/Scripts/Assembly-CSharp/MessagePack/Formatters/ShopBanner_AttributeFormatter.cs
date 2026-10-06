namespace MessagePack.Formatters
{
	public sealed class ShopBanner_AttributeFormatter : IMessagePackFormatter<ShopBanner.Attribute>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ShopBanner.Attribute value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ShopBanner.Attribute Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
