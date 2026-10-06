namespace MessagePack.Formatters
{
	public sealed class APIComFriendApply_RequestFormatter : IMessagePackFormatter<APIComFriendApply.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIComFriendApply.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIComFriendApply.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
