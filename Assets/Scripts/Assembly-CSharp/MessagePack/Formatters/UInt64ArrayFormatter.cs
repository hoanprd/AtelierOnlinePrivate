namespace MessagePack.Formatters
{
	public sealed class UInt64ArrayFormatter : IMessagePackFormatter<ulong[]>, IMessagePackFormatter
	{
		public static readonly UInt64ArrayFormatter Instance;

		private UInt64ArrayFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, ulong[] value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ulong[] Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
