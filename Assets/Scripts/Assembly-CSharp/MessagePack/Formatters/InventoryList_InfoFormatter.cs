namespace MessagePack.Formatters
{
	public sealed class InventoryList_InfoFormatter : IMessagePackFormatter<InventoryList.Info>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, InventoryList.Info value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public InventoryList.Info Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
