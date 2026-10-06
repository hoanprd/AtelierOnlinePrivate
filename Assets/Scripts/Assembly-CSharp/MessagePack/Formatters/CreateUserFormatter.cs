namespace MessagePack.Formatters
{
	public sealed class CreateUserFormatter : IMessagePackFormatter<CreateUser>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, CreateUser value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public CreateUser Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
