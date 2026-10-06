namespace MessagePack.Formatters
{
	public sealed class NullableForceInt16BlockFormatter : IMessagePackFormatter<short?>, IMessagePackFormatter
	{
		public static readonly NullableForceInt16BlockFormatter Instance;

		private NullableForceInt16BlockFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, short? value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public short? Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
