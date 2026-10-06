namespace MessagePack.Formatters
{
	public sealed class FriendList_FriendLimitFormatter : IMessagePackFormatter<FriendList.FriendLimit>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, FriendList.FriendLimit value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public FriendList.FriendLimit Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
