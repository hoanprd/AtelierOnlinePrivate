namespace MessagePack.Formatters
{
	public sealed class QuestSummaryFormatter : IMessagePackFormatter<QuestSummary>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, QuestSummary value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public QuestSummary Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
