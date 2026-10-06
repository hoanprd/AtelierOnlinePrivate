namespace MessagePack.Formatters
{
	public sealed class APITitleUserOauth_RequestFormatter : IMessagePackFormatter<APITitleUserOauth.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APITitleUserOauth.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APITitleUserOauth.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
