namespace MessagePack.Formatters
{
	public sealed class CharFormatter : IMessagePackFormatter<char>, IMessagePackFormatter
	{
		public static readonly CharFormatter Instance;

		private CharFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, char value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public char Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return '\0';
		}
	}
}
