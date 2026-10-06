namespace MessagePack.Formatters
{
	public sealed class AlchemyUserInfoFormatter : IMessagePackFormatter<AlchemyUserInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, AlchemyUserInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public AlchemyUserInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
