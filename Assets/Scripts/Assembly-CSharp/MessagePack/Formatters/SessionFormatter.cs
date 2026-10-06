namespace MessagePack.Formatters
{
	public sealed class SessionFormatter : IMessagePackFormatter<Session>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, Session value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public Session Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
