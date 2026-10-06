namespace MessagePack.Formatters
{
	public sealed class UserInfoFormatter : IMessagePackFormatter<UserInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, UserInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public UserInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
