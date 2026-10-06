namespace MessagePack.Formatters
{
	public sealed class FriendListFormatter : IMessagePackFormatter<FriendList>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, FriendList value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public FriendList Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
