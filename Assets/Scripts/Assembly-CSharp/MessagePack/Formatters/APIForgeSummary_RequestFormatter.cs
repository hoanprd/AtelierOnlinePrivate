namespace MessagePack.Formatters
{
	public sealed class APIForgeSummary_RequestFormatter : IMessagePackFormatter<APIForgeSummary.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIForgeSummary.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIForgeSummary.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
