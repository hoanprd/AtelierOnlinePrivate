namespace MessagePack.Formatters
{
	public sealed class QuestStartResponseFormatter : IMessagePackFormatter<QuestStartResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, QuestStartResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public QuestStartResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
