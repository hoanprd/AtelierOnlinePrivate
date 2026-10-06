namespace MessagePack.Formatters
{
	public sealed class APIRespireFusion_Request_FeedFormatter : IMessagePackFormatter<APIRespireFusion.Request.Feed>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIRespireFusion.Request.Feed value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIRespireFusion.Request.Feed Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
