namespace MessagePack.Formatters
{
	public sealed class APIComFriendAccept_Request_TargetFormatter : IMessagePackFormatter<APIComFriendAccept.Request.Target>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIComFriendAccept.Request.Target value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIComFriendAccept.Request.Target Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
