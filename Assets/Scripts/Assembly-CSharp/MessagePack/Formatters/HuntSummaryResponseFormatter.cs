namespace MessagePack.Formatters
{
	public sealed class HuntSummaryResponseFormatter : IMessagePackFormatter<HuntSummaryResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, HuntSummaryResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public HuntSummaryResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
