namespace MessagePack.Formatters
{
	public sealed class UInt16ArrayFormatter : IMessagePackFormatter<ushort[]>, IMessagePackFormatter
	{
		public static readonly UInt16ArrayFormatter Instance;

		private UInt16ArrayFormatter()
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
