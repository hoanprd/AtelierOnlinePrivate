namespace MessagePack.Formatters
{
	public sealed class BannerInfoFormatter : IMessagePackFormatter<BannerInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, BannerInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public BannerInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
