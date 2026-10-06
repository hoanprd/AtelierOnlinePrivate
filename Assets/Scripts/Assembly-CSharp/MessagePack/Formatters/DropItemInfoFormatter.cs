namespace MessagePack.Formatters
{
	public sealed class DropItemInfoFormatter : IMessagePackFormatter<DropItemInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, DropItemInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public DropItemInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
