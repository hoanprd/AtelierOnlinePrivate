namespace MessagePack.Formatters
{
	public sealed class ItemSprinkleResponseFormatter : IMessagePackFormatter<ItemSprinkleResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ItemSprinkleResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ItemSprinkleResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
