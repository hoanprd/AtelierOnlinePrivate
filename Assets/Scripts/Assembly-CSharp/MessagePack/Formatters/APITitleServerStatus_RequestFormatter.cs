namespace MessagePack.Formatters
{
	public sealed class APITitleServerStatus_RequestFormatter : IMessagePackFormatter<APITitleServerStatus.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APITitleServerStatus.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APITitleServerStatus.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
