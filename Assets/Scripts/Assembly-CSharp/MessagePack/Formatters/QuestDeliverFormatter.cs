namespace MessagePack.Formatters
{
	public sealed class QuestDeliverFormatter : IMessagePackFormatter<QuestDeliver>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, QuestDeliver value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public QuestDeliver Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
