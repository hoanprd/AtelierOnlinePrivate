namespace MessagePack.Formatters
{
	public sealed class WealthInfoFormatter : IMessagePackFormatter<WealthInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, WealthInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public WealthInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
