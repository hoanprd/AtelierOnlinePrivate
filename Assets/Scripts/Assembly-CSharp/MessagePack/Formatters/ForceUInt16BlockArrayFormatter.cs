namespace MessagePack.Formatters
{
	public sealed class ForceUInt16BlockArrayFormatter : IMessagePackFormatter<ushort[]>, IMessagePackFormatter
	{
		public static readonly ForceUInt16BlockArrayFormatter Instance;

		private ForceUInt16BlockArrayFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, ushort[] value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ushort[] Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
