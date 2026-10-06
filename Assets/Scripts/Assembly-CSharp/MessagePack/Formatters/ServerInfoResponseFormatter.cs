namespace MessagePack.Formatters
{
	public sealed class ServerInfoResponseFormatter : IMessagePackFormatter<ServerInfoResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ServerInfoResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ServerInfoResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
