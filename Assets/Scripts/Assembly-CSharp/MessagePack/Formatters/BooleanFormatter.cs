namespace MessagePack.Formatters
{
	public sealed class BooleanFormatter : IMessagePackFormatter<bool>, IMessagePackFormatter
	{
		public static readonly BooleanFormatter Instance;

		private BooleanFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, bool value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public bool Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return false;
		}
	}
}
