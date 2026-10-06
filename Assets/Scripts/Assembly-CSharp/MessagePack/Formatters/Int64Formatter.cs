namespace MessagePack.Formatters
{
	public sealed class Int64Formatter : IMessagePackFormatter<long>, IMessagePackFormatter
	{
		public static readonly Int64Formatter Instance;

		private Int64Formatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, long value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public long Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return 0L;
		}
	}
}
