namespace MessagePack.Formatters
{
	public sealed class PresentInfoFormatter : IMessagePackFormatter<PresentInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, PresentInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public PresentInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
