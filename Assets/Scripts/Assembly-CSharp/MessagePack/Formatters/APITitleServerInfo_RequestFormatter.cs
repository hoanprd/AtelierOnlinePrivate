namespace MessagePack.Formatters
{
	public sealed class APITitleServerInfo_RequestFormatter : IMessagePackFormatter<APITitleServerInfo.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APITitleServerInfo.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APITitleServerInfo.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
