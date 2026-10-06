namespace MessagePack.Formatters
{
	public sealed class APIForgeSummary_Request_CategoryFormatter : IMessagePackFormatter<APIForgeSummary.Request.Category>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIForgeSummary.Request.Category value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIForgeSummary.Request.Category Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
