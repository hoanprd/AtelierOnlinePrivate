namespace MessagePack.Formatters
{
	public sealed class StrageShowResponseFormatter : IMessagePackFormatter<StrageShowResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, StrageShowResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public StrageShowResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
