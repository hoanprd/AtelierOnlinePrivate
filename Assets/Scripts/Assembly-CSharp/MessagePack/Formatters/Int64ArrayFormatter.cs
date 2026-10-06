namespace MessagePack.Formatters
{
	public sealed class Int64ArrayFormatter : IMessagePackFormatter<long[]>, IMessagePackFormatter
	{
		public static readonly Int64ArrayFormatter Instance;

		private Int64ArrayFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, long[] value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public long[] Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
