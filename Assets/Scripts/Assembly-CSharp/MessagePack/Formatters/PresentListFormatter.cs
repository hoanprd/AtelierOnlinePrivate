namespace MessagePack.Formatters
{
	public sealed class PresentListFormatter : IMessagePackFormatter<PresentList>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, PresentList value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public PresentList Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
