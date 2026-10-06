namespace MessagePack.Formatters
{
	public sealed class ServerStatusResponseFormatter : IMessagePackFormatter<ServerStatusResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ServerStatusResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ServerStatusResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
