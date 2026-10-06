namespace MessagePack.Formatters
{
	public sealed class APIForgeEnforce_Request_FeedFormatter : IMessagePackFormatter<APIForgeEnforce.Request.Feed>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIForgeEnforce.Request.Feed value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIForgeEnforce.Request.Feed Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
