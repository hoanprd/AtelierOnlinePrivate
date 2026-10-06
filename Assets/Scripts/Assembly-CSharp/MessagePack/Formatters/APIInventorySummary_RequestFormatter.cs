namespace MessagePack.Formatters
{
	public sealed class APIInventorySummary_RequestFormatter : IMessagePackFormatter<APIInventorySummary.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIInventorySummary.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIInventorySummary.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
