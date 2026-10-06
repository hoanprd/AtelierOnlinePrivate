namespace MessagePack.Formatters
{
	public sealed class QuestCompleteFormatter : IMessagePackFormatter<QuestComplete>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, QuestComplete value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public QuestComplete Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
