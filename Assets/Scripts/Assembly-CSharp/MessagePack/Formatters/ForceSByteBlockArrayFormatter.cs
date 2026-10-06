namespace MessagePack.Formatters
{
	public sealed class ForceSByteBlockArrayFormatter : IMessagePackFormatter<sbyte[]>, IMessagePackFormatter
	{
		public static readonly ForceSByteBlockArrayFormatter Instance;

		private ForceSByteBlockArrayFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, sbyte[] value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public sbyte[] Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
