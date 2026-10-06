namespace MessagePack.Formatters
{
	public sealed class QuestStartFormatter : IMessagePackFormatter<QuestStart>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, QuestStart value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public QuestStart Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
