namespace MessagePack.Formatters
{
	public sealed class NullableForceUInt32BlockFormatter : IMessagePackFormatter<uint?>, IMessagePackFormatter
	{
		public static readonly NullableForceUInt32BlockFormatter Instance;

		private NullableForceUInt32BlockFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, uint? value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public uint? Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
