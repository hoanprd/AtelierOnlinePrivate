namespace MessagePack.Formatters
{
	public sealed class NullableUInt64Formatter : IMessagePackFormatter<ulong?>, IMessagePackFormatter
	{
		public static readonly NullableUInt64Formatter Instance;

		private NullableUInt64Formatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, ulong? value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ulong? Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
