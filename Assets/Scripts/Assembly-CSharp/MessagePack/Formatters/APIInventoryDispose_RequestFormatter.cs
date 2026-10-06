namespace MessagePack.Formatters
{
	public sealed class APIInventoryDispose_RequestFormatter : IMessagePackFormatter<APIInventoryDispose.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIInventoryDispose.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIInventoryDispose.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
