namespace MessagePack.Formatters
{
	public sealed class APIRespireSummary_Request_CategoryFormatter : IMessagePackFormatter<APIRespireSummary.Request.Category>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIRespireSummary.Request.Category value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIRespireSummary.Request.Category Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
