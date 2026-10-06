namespace MessagePack.Formatters
{
	public sealed class UInt16Formatter : IMessagePackFormatter<ushort>, IMessagePackFormatter
	{
		public static readonly UInt16Formatter Instance;

		private UInt16Formatter()
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
