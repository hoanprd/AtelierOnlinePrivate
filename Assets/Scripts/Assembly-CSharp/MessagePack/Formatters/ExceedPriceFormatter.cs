namespace MessagePack.Formatters
{
	public sealed class ExceedPriceFormatter : IMessagePackFormatter<ExceedPrice>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ExceedPrice value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ExceedPrice Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
