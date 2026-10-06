namespace MessagePack.Formatters
{
	public sealed class FriendDataFormatter : IMessagePackFormatter<FriendData>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, FriendData value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public FriendData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
