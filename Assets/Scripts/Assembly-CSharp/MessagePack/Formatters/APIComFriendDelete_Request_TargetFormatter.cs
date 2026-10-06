namespace MessagePack.Formatters
{
	public sealed class APIComFriendDelete_Request_TargetFormatter : IMessagePackFormatter<APIComFriendDelete.Request.Target>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIComFriendDelete.Request.Target value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIComFriendDelete.Request.Target Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
