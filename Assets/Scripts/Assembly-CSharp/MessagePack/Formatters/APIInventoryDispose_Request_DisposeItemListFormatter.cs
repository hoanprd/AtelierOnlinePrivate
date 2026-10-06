namespace MessagePack.Formatters
{
	public sealed class APIInventoryDispose_Request_DisposeItemListFormatter : IMessagePackFormatter<APIInventoryDispose.Request.DisposeItemList>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIInventoryDispose.Request.DisposeItemList value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIInventoryDispose.Request.DisposeItemList Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
