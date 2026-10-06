namespace MessagePack.Formatters
{
	public sealed class WealthListFormatter : IMessagePackFormatter<WealthList>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, WealthList value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public WealthList Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
