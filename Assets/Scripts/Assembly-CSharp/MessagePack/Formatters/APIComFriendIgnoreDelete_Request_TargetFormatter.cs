namespace MessagePack.Formatters
{
	public sealed class APIComFriendIgnoreDelete_Request_TargetFormatter : IMessagePackFormatter<APIComFriendIgnoreDelete.Request.Target>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIComFriendIgnoreDelete.Request.Target value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIComFriendIgnoreDelete.Request.Target Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
