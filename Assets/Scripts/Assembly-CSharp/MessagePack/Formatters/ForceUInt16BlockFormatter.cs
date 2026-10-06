namespace MessagePack.Formatters
{
	public sealed class ForceUInt16BlockFormatter : IMessagePackFormatter<ushort>, IMessagePackFormatter
	{
		public static readonly ForceUInt16BlockFormatter Instance;

		private ForceUInt16BlockFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, ushort value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ushort Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return 0;
		}
	}
}
