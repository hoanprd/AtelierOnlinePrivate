namespace MessagePack.Formatters
{
	public sealed class NullableForceUInt64BlockFormatter : IMessagePackFormatter<ulong?>, IMessagePackFormatter
	{
		public static readonly NullableForceUInt64BlockFormatter Instance;

		private NullableForceUInt64BlockFormatter()
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
