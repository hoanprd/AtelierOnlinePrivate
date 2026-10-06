namespace MessagePack.Formatters
{
	public sealed class BannerCategoryFormatter : IMessagePackFormatter<BannerCategory>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, BannerCategory value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public BannerCategory Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return BannerCategory.NONE;
		}
	}
}
