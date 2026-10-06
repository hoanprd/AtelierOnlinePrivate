namespace MessagePack.Formatters
{
	public sealed class ExceedInfoResponseFormatter : IMessagePackFormatter<ExceedInfoResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ExceedInfoResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ExceedInfoResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
