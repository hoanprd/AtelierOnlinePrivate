namespace MessagePack.Formatters
{
	public sealed class FieldEnterResponseFormatter : IMessagePackFormatter<FieldEnterResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, FieldEnterResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public FieldEnterResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
