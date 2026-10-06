namespace MessagePack.Formatters
{
	public sealed class ForceSByteBlockFormatter : IMessagePackFormatter<sbyte>, IMessagePackFormatter
	{
		public static readonly ForceSByteBlockFormatter Instance;

		private ForceSByteBlockFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, sbyte value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public sbyte Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return 0;
		}
	}
}
