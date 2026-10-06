namespace MessagePack.Formatters
{
	public sealed class FairyItemInfoFormatter : IMessagePackFormatter<FairyItemInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, FairyItemInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public FairyItemInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
