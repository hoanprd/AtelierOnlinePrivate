namespace MessagePack.Formatters
{
	public sealed class InventoryEnlargeResponseFormatter : IMessagePackFormatter<InventoryEnlargeResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, InventoryEnlargeResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public InventoryEnlargeResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
