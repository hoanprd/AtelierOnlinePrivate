namespace MessagePack.Formatters
{
	public sealed class FairyItemResponseFormatter : IMessagePackFormatter<FairyItemResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, FairyItemResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public FairyItemResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
