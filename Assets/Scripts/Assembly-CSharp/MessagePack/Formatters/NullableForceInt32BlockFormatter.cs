namespace MessagePack.Formatters
{
	public sealed class NullableForceInt32BlockFormatter : IMessagePackFormatter<int?>, IMessagePackFormatter
	{
		public static readonly NullableForceInt32BlockFormatter Instance;

		private NullableForceInt32BlockFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, int? value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public int? Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
