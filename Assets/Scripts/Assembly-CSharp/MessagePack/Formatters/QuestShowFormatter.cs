namespace MessagePack.Formatters
{
	public sealed class QuestShowFormatter : IMessagePackFormatter<QuestShow>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, QuestShow value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public QuestShow Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
