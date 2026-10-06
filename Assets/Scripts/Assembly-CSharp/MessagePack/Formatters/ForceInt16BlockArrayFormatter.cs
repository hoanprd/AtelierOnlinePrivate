namespace MessagePack.Formatters
{
	public sealed class ForceInt16BlockArrayFormatter : IMessagePackFormatter<short[]>, IMessagePackFormatter
	{
		public static readonly ForceInt16BlockArrayFormatter Instance;

		private ForceInt16BlockArrayFormatter()
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
