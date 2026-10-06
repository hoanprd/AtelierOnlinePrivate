namespace MessagePack.Formatters
{
	public sealed class EXPTableFormatter : IMessagePackFormatter<EXPTable>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, EXPTable value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public EXPTable Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
