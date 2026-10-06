namespace MessagePack.Formatters
{
	public sealed class InventoryStatusFormatter : IMessagePackFormatter<InventoryStatus>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, InventoryStatus value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public InventoryStatus Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
