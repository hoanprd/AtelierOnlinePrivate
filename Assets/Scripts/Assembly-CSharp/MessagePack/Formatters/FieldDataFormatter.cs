namespace MessagePack.Formatters
{
	public sealed class FieldDataFormatter : IMessagePackFormatter<FieldData>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, FieldData value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public FieldData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
