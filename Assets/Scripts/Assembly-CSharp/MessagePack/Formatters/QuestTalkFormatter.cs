namespace MessagePack.Formatters
{
	public sealed class QuestTalkFormatter : IMessagePackFormatter<QuestTalk>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, QuestTalk value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public QuestTalk Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
