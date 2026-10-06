namespace MessagePack.Formatters
{
	public sealed class EventInfoFormatter : IMessagePackFormatter<EventInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, EventInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public EventInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
