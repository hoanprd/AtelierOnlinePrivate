namespace MessagePack.Formatters
{
	public sealed class APIHomeInventoryReposit_RequestFormatter : IMessagePackFormatter<APIHomeInventoryReposit.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIHomeInventoryReposit.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIHomeInventoryReposit.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
