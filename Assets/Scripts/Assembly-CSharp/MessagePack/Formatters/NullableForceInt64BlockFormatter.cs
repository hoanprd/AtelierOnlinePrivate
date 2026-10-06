namespace MessagePack.Formatters
{
	public sealed class NullableForceInt64BlockFormatter : IMessagePackFormatter<long?>, IMessagePackFormatter
	{
		public static readonly NullableForceInt64BlockFormatter Instance;

		private NullableForceInt64BlockFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, long? value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public long? Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
