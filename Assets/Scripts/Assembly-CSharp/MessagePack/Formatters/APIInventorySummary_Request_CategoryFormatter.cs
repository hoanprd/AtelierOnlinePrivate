namespace MessagePack.Formatters
{
	public sealed class APIInventorySummary_Request_CategoryFormatter : IMessagePackFormatter<APIInventorySummary.Request.Category>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIInventorySummary.Request.Category value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIInventorySummary.Request.Category Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
