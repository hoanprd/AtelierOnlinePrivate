namespace MessagePack.Formatters
{
	public sealed class APIComCheckWord_RequestFormatter : IMessagePackFormatter<APIComCheckWord.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIComCheckWord.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIComCheckWord.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
