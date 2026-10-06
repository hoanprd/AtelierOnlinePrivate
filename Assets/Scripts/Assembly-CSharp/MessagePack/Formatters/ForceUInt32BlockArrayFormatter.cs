namespace MessagePack.Formatters
{
	public sealed class ForceUInt32BlockArrayFormatter : IMessagePackFormatter<uint[]>, IMessagePackFormatter
	{
		public static readonly ForceUInt32BlockArrayFormatter Instance;

		private ForceUInt32BlockArrayFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, uint[] value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public uint[] Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
