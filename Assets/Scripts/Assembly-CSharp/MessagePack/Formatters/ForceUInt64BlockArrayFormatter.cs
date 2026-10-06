namespace MessagePack.Formatters
{
	public sealed class ForceUInt64BlockArrayFormatter : IMessagePackFormatter<ulong[]>, IMessagePackFormatter
	{
		public static readonly ForceUInt64BlockArrayFormatter Instance;

		private ForceUInt64BlockArrayFormatter()
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
