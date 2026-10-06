namespace MessagePack.Formatters
{
	public sealed class ForceInt16BlockFormatter : IMessagePackFormatter<short>, IMessagePackFormatter
	{
		public static readonly ForceInt16BlockFormatter Instance;

		private ForceInt16BlockFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, short value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public short Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return 0;
		}
	}
}
