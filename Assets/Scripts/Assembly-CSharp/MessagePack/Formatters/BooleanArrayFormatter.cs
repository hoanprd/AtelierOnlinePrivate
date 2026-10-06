namespace MessagePack.Formatters
{
	public sealed class BooleanArrayFormatter : IMessagePackFormatter<bool[]>, IMessagePackFormatter
	{
		public static readonly BooleanArrayFormatter Instance;

		private BooleanArrayFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, bool[] value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public bool[] Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
