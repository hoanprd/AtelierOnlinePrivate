namespace MessagePack.Formatters
{
	public sealed class Int32ArrayFormatter : IMessagePackFormatter<int[]>, IMessagePackFormatter
	{
		public static readonly Int32ArrayFormatter Instance;

		private Int32ArrayFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, int[] value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public int[] Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
