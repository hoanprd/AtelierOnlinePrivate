namespace MessagePack.Formatters
{
	public sealed class PresentItemInfoFormatter : IMessagePackFormatter<PresentItemInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, PresentItemInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public PresentItemInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
