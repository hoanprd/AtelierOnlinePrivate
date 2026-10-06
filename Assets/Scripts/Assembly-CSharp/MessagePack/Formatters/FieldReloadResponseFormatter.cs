namespace MessagePack.Formatters
{
	public sealed class FieldReloadResponseFormatter : IMessagePackFormatter<FieldReloadResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, FieldReloadResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public FieldReloadResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
