namespace MessagePack.Formatters
{
	public sealed class Int16Formatter : IMessagePackFormatter<short>, IMessagePackFormatter
	{
		public static readonly Int16Formatter Instance;

		private Int16Formatter()
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
