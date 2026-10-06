namespace MessagePack.Formatters
{
	public sealed class FriendProfileResponseFormatter : IMessagePackFormatter<FriendProfileResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, FriendProfileResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public FriendProfileResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
