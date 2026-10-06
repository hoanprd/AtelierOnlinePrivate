namespace MessagePack.Formatters
{
	public sealed class FriendInfoResponseFormatter : IMessagePackFormatter<FriendInfoResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, FriendInfoResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public FriendInfoResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
