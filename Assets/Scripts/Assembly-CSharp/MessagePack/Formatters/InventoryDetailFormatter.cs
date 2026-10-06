namespace MessagePack.Formatters
{
	public sealed class InventoryDetailFormatter : IMessagePackFormatter<InventoryDetail>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, InventoryDetail value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public InventoryDetail Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
