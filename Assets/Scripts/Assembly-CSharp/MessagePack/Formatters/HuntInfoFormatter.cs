namespace MessagePack.Formatters
{
	public sealed class HuntInfoFormatter : IMessagePackFormatter<HuntInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, HuntInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public HuntInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
