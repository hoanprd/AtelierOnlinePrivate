namespace MessagePack.Formatters
{
	public sealed class APITitleUserResearch_RequestFormatter : IMessagePackFormatter<APITitleUserResearch.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APITitleUserResearch.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APITitleUserResearch.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
