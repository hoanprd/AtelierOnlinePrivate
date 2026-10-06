namespace MessagePack.Formatters
{
	public sealed class APIHomeInventoryRestore_RequestFormatter : IMessagePackFormatter<APIHomeInventoryRestore.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIHomeInventoryRestore.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIHomeInventoryRestore.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
