namespace MessagePack.Formatters
{
	public sealed class APIHomeInventoryRestore_Request_InventoryIDFormatter : IMessagePackFormatter<APIHomeInventoryRestore.Request.InventoryID>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIHomeInventoryRestore.Request.InventoryID value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIHomeInventoryRestore.Request.InventoryID Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
