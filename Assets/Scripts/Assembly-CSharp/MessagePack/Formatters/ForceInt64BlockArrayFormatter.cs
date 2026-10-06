namespace MessagePack.Formatters
{
	public sealed class ForceInt64BlockArrayFormatter : IMessagePackFormatter<long[]>, IMessagePackFormatter
	{
		public static readonly ForceInt64BlockArrayFormatter Instance;

		private ForceInt64BlockArrayFormatter()
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
