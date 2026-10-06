namespace MessagePack.Formatters
{
	public sealed class NullableStringFormatter : IMessagePackFormatter<string>, IMessagePackFormatter
	{
		public static readonly NullableStringFormatter Instance;

		private NullableStringFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, string value, IFormatterResolver typeResolver)
		{
			return 0;
		}

		public string Deserialize(byte[] bytes, int offset, IFormatterResolver typeResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
