namespace MessagePack.Formatters
{
	public sealed class UInt32Formatter : IMessagePackFormatter<uint>, IMessagePackFormatter
	{
		public static readonly UInt32Formatter Instance;

		private UInt32Formatter()
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
