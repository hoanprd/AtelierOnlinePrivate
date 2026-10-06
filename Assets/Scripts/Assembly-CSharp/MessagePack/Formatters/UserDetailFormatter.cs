namespace MessagePack.Formatters
{
	public sealed class UserDetailFormatter : IMessagePackFormatter<UserDetail>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, UserDetail value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public UserDetail Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
