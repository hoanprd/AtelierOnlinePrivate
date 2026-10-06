namespace MessagePack.Formatters
{
	public sealed class QuestDeliverResponseFormatter : IMessagePackFormatter<QuestDeliverResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, QuestDeliverResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public QuestDeliverResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
