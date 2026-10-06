namespace MessagePack.Formatters
{
	public sealed class APIComFriendProfile_RequestFormatter : IMessagePackFormatter<APIComFriendProfile.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIComFriendProfile.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIComFriendProfile.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
