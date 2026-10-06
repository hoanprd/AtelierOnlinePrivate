namespace MessagePack.Formatters
{
	public sealed class QuestConditionsFormatter : IMessagePackFormatter<QuestConditions>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, QuestConditions value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public QuestConditions Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
