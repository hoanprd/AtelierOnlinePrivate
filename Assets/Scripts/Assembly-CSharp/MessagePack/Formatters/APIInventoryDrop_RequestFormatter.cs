namespace MessagePack.Formatters
{
	public sealed class APIInventoryDrop_RequestFormatter : IMessagePackFormatter<APIInventoryDrop.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIInventoryDrop.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIInventoryDrop.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
