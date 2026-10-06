namespace MessagePack.Formatters
{
	public sealed class BannerAttributeTypeFormatter : IMessagePackFormatter<BannerAttributeType>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, BannerAttributeType value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public BannerAttributeType Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return BannerAttributeType.NONE;
		}
	}
}
