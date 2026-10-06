namespace MessagePack.Formatters
{
	public sealed class QuestGiveupFormatter : IMessagePackFormatter<QuestGiveup>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, QuestGiveup value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public QuestGiveup Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
