namespace MessagePack.Formatters
{
	public sealed class ServerStatusResponse_Status_UrlInfoFormatter : IMessagePackFormatter<ServerStatusResponse.Status.UrlInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ServerStatusResponse.Status.UrlInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ServerStatusResponse.Status.UrlInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
