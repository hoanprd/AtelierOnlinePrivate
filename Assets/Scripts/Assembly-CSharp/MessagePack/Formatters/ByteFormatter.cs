namespace MessagePack.Formatters
{
	public sealed class ByteFormatter : IMessagePackFormatter<byte>, IMessagePackFormatter
	{
		public static readonly ByteFormatter Instance;

		private ByteFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, byte value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public byte Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return 0;
		}
	}
}
