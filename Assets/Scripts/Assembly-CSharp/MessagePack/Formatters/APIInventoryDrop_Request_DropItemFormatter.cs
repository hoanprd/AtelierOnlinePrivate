namespace MessagePack.Formatters
{
	public sealed class APIInventoryDrop_Request_DropItemFormatter : IMessagePackFormatter<APIInventoryDrop.Request.DropItem>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIInventoryDrop.Request.DropItem value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIInventoryDrop.Request.DropItem Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
