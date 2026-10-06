namespace MessagePack.Formatters
{
	public sealed class QuestDetailFormatter : IMessagePackFormatter<QuestDetail>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, QuestDetail value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public QuestDetail Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
