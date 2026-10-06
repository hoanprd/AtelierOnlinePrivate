namespace MessagePack.Formatters
{
	public sealed class UInt32ArrayFormatter : IMessagePackFormatter<uint[]>, IMessagePackFormatter
	{
		public static readonly UInt32ArrayFormatter Instance;

		private UInt32ArrayFormatter()
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
