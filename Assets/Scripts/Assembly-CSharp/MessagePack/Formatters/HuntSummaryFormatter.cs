namespace MessagePack.Formatters
{
	public sealed class HuntSummaryFormatter : IMessagePackFormatter<HuntSummary>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, HuntSummary value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public HuntSummary Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
