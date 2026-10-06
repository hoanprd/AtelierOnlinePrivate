namespace MessagePack.Formatters
{
	public sealed class ForceInt32BlockArrayFormatter : IMessagePackFormatter<int[]>, IMessagePackFormatter
	{
		public static readonly ForceInt32BlockArrayFormatter Instance;

		private ForceInt32BlockArrayFormatter()
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
