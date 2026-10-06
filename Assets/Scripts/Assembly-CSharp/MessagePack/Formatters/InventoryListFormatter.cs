namespace MessagePack.Formatters
{
	public sealed class InventoryListFormatter : IMessagePackFormatter<InventoryList>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, InventoryList value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public InventoryList Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
