namespace MessagePack.Formatters
{
	public sealed class APIComInventoryUnhold_RequestFormatter : IMessagePackFormatter<APIComInventoryUnhold.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIComInventoryUnhold.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIComInventoryUnhold.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
