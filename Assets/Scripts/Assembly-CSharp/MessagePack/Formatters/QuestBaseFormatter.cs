namespace MessagePack.Formatters
{
	public sealed class QuestBaseFormatter : IMessagePackFormatter<QuestBase>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, QuestBase value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public QuestBase Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
