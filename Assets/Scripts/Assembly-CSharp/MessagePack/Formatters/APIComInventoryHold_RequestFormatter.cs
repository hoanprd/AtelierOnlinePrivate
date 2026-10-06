namespace MessagePack.Formatters
{
	public sealed class APIComInventoryHold_RequestFormatter : IMessagePackFormatter<APIComInventoryHold.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIComInventoryHold.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIComInventoryHold.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
