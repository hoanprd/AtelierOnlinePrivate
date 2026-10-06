namespace MessagePack.Formatters
{
	public sealed class APIComFriendIgnoreAdd_RequestFormatter : IMessagePackFormatter<APIComFriendIgnoreAdd.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIComFriendIgnoreAdd.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIComFriendIgnoreAdd.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
