namespace MessagePack.Formatters
{
	public sealed class APITitleUserExchange_RequestFormatter : IMessagePackFormatter<APITitleUserExchange.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APITitleUserExchange.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APITitleUserExchange.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
