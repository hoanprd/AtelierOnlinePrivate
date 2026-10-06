namespace MessagePack.Formatters
{
	public sealed class FieldDataResponseFormatter : IMessagePackFormatter<FieldDataResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, FieldDataResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public FieldDataResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
