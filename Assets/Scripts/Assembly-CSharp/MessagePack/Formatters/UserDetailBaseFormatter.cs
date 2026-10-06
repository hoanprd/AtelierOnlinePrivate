namespace MessagePack.Formatters
{
	public sealed class UserDetailBaseFormatter : IMessagePackFormatter<UserDetailBase>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, UserDetailBase value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public UserDetailBase Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
