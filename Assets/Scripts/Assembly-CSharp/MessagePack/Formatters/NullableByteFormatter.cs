namespace MessagePack.Formatters
{
	public sealed class NullableByteFormatter : IMessagePackFormatter<byte?>, IMessagePackFormatter
	{
		public static readonly NullableByteFormatter Instance;

		private NullableByteFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, byte? value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public byte? Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
