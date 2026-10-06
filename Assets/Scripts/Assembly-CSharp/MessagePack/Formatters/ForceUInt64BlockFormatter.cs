namespace MessagePack.Formatters
{
	public sealed class ForceUInt64BlockFormatter : IMessagePackFormatter<ulong>, IMessagePackFormatter
	{
		public static readonly ForceUInt64BlockFormatter Instance;

		private ForceUInt64BlockFormatter()
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
