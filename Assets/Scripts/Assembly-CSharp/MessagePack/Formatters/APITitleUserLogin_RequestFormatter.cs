namespace MessagePack.Formatters
{
	public sealed class APITitleUserLogin_RequestFormatter : IMessagePackFormatter<APITitleUserLogin.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APITitleUserLogin.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APITitleUserLogin.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
