namespace MessagePack.Formatters
{
	public sealed class QuestDeliver_PresentFormatter : IMessagePackFormatter<QuestDeliver.Present>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, QuestDeliver.Present value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public QuestDeliver.Present Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
