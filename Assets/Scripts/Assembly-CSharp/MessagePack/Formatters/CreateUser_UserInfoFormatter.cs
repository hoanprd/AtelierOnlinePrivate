namespace MessagePack.Formatters
{
	public sealed class CreateUser_UserInfoFormatter : IMessagePackFormatter<CreateUser.UserInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, CreateUser.UserInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public CreateUser.UserInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
