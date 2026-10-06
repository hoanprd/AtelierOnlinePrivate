namespace MessagePack.Formatters
{
	public sealed class QuestSummaryResponseFormatter : IMessagePackFormatter<QuestSummaryResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, QuestSummaryResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public QuestSummaryResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
