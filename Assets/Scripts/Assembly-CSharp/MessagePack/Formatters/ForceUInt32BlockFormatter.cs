namespace MessagePack.Formatters
{
	public sealed class ForceUInt32BlockFormatter : IMessagePackFormatter<uint>, IMessagePackFormatter
	{
		public static readonly ForceUInt32BlockFormatter Instance;

		private ForceUInt32BlockFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, uint value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public uint Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return 0u;
		}
	}
}
