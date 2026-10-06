namespace MessagePack.Formatters
{
	public sealed class ForceInt32BlockFormatter : IMessagePackFormatter<int>, IMessagePackFormatter
	{
		public static readonly ForceInt32BlockFormatter Instance;

		private ForceInt32BlockFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, int value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public int Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return 0;
		}
	}
}
