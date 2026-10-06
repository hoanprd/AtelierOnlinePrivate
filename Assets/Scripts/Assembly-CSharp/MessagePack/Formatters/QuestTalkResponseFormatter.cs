namespace MessagePack.Formatters
{
	public sealed class QuestTalkResponseFormatter : IMessagePackFormatter<QuestTalkResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, QuestTalkResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public QuestTalkResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
