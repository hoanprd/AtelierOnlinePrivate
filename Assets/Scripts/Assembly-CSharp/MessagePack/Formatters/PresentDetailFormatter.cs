namespace MessagePack.Formatters
{
	public sealed class PresentDetailFormatter : IMessagePackFormatter<PresentDetail>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, PresentDetail value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public PresentDetail Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
