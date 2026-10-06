namespace MessagePack.Formatters
{
	public sealed class PresentWealthInfoFormatter : IMessagePackFormatter<PresentWealthInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, PresentWealthInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public PresentWealthInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
