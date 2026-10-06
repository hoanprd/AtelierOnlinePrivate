namespace MessagePack.Formatters
{
	public sealed class APIOverwritePicktrait_RequestFormatter : IMessagePackFormatter<APIOverwritePicktrait.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIOverwritePicktrait.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIOverwritePicktrait.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
