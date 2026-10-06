namespace MessagePack.Formatters
{
	public sealed class QuestInfoFormatter : IMessagePackFormatter<QuestInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, QuestInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public QuestInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
