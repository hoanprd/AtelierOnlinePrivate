namespace MessagePack.Formatters
{
	public sealed class ItemParamFormatter : IMessagePackFormatter<ItemParam>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ItemParam value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ItemParam Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
