namespace MessagePack.Formatters
{
	public sealed class APIComFriendSearch_RequestFormatter : IMessagePackFormatter<APIComFriendSearch.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIComFriendSearch.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIComFriendSearch.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
