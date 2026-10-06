namespace MessagePack.Formatters
{
	public sealed class QuestGiveupResponseFormatter : IMessagePackFormatter<QuestGiveupResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, QuestGiveupResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public QuestGiveupResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
