namespace MessagePack.Formatters
{
	public sealed class APIHomeInventoryBring_Request_RetainItemFormatter : IMessagePackFormatter<APIHomeInventoryBring.Request.RetainItem>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIHomeInventoryBring.Request.RetainItem value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIHomeInventoryBring.Request.RetainItem Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
