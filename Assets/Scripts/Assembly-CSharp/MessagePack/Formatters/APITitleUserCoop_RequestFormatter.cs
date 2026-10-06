namespace MessagePack.Formatters
{
	public sealed class APITitleUserCoop_RequestFormatter : IMessagePackFormatter<APITitleUserCoop.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APITitleUserCoop.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APITitleUserCoop.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
