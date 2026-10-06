namespace MessagePack.Formatters
{
	public sealed class APIComFriendAccept_RequestFormatter : IMessagePackFormatter<APIComFriendAccept.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIComFriendAccept.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIComFriendAccept.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
