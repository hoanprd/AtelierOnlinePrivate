namespace MessagePack.Formatters
{
	public sealed class APITitleUserCreate_RequestFormatter : IMessagePackFormatter<APITitleUserCreate.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APITitleUserCreate.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APITitleUserCreate.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
