namespace MessagePack.Formatters
{
	public sealed class FriendSearchResponseFormatter : IMessagePackFormatter<FriendSearchResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, FriendSearchResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public FriendSearchResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
