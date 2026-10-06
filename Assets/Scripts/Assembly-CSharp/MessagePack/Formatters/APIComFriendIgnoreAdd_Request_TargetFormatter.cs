namespace MessagePack.Formatters
{
	public sealed class APIComFriendIgnoreAdd_Request_TargetFormatter : IMessagePackFormatter<APIComFriendIgnoreAdd.Request.Target>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIComFriendIgnoreAdd.Request.Target value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIComFriendIgnoreAdd.Request.Target Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
