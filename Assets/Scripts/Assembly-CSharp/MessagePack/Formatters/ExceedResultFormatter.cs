namespace MessagePack.Formatters
{
	public sealed class ExceedResultFormatter : IMessagePackFormatter<ExceedResult>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ExceedResult value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ExceedResult Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
