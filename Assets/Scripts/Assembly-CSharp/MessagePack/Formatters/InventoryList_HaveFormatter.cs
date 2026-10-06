namespace MessagePack.Formatters
{
	public sealed class InventoryList_HaveFormatter : IMessagePackFormatter<InventoryList.Have>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, InventoryList.Have value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public InventoryList.Have Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
