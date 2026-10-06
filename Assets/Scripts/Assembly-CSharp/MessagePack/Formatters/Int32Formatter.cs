namespace MessagePack.Formatters
{
	public sealed class Int32Formatter : IMessagePackFormatter<int>, IMessagePackFormatter
	{
		public static readonly Int32Formatter Instance;

		private Int32Formatter()
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
