namespace MessagePack.Formatters
{
	public sealed class NullableForceUInt16BlockFormatter : IMessagePackFormatter<ushort?>, IMessagePackFormatter
	{
		public static readonly NullableForceUInt16BlockFormatter Instance;

		private NullableForceUInt16BlockFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, ushort? value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ushort? Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
