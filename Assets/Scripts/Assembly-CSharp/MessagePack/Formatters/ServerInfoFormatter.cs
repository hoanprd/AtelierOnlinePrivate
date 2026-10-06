namespace MessagePack.Formatters
{
	public sealed class ServerInfoFormatter : IMessagePackFormatter<ServerInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ServerInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ServerInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
