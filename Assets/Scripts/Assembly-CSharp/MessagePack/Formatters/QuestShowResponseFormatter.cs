namespace MessagePack.Formatters
{
	public sealed class QuestShowResponseFormatter : IMessagePackFormatter<QuestShowResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, QuestShowResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public QuestShowResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
