namespace MessagePack.Formatters
{
	public sealed class RankingSummaryResponseFormatter : IMessagePackFormatter<RankingSummaryResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RankingSummaryResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RankingSummaryResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
