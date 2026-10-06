namespace MessagePack.Formatters
{
	public sealed class FieldEnter2ResponseFormatter : IMessagePackFormatter<FieldEnter2Response>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, FieldEnter2Response value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public FieldEnter2Response Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
