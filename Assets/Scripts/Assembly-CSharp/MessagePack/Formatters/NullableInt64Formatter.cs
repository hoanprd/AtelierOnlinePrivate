namespace MessagePack.Formatters
{
	public sealed class NullableInt64Formatter : IMessagePackFormatter<long?>, IMessagePackFormatter
	{
		public static readonly NullableInt64Formatter Instance;

		private NullableInt64Formatter()
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
