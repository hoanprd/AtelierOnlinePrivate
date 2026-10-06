namespace MessagePack.Formatters
{
	public sealed class ServerStatusResponse_StatusFormatter : IMessagePackFormatter<ServerStatusResponse.Status>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ServerStatusResponse.Status value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ServerStatusResponse.Status Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
