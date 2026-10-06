namespace MessagePack.Formatters
{
	public sealed class BannerInfoResponseFormatter : IMessagePackFormatter<BannerInfoResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, BannerInfoResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public BannerInfoResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
