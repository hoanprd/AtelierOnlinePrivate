namespace MessagePack.Formatters
{
	public sealed class Int16ArrayFormatter : IMessagePackFormatter<short[]>, IMessagePackFormatter
	{
		public static readonly Int16ArrayFormatter Instance;

		private Int16ArrayFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, short[] value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public short[] Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
