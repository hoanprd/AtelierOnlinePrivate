namespace MessagePack.Formatters
{
	public sealed class APIHomeInventoryBring_RequestFormatter : IMessagePackFormatter<APIHomeInventoryBring.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIHomeInventoryBring.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIHomeInventoryBring.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
