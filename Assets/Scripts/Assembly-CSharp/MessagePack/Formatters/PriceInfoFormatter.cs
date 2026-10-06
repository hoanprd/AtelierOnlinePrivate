namespace MessagePack.Formatters
{
	public sealed class PriceInfoFormatter : IMessagePackFormatter<PriceInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, PriceInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public PriceInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
