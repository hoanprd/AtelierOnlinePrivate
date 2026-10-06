namespace MessagePack.Formatters
{
	public sealed class InventoryInfoFormatter : IMessagePackFormatter<InventoryInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, InventoryInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public InventoryInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
