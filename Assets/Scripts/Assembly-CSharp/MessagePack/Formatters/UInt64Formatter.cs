namespace MessagePack.Formatters
{
	public sealed class UInt64Formatter : IMessagePackFormatter<ulong>, IMessagePackFormatter
	{
		public static readonly UInt64Formatter Instance;

		private UInt64Formatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, ulong value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ulong Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return 0uL;
		}
	}
}
