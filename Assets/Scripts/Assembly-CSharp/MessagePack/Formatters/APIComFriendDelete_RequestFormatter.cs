namespace MessagePack.Formatters
{
	public sealed class APIComFriendDelete_RequestFormatter : IMessagePackFormatter<APIComFriendDelete.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIComFriendDelete.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIComFriendDelete.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
