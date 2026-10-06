namespace MessagePack.Formatters
{
	public sealed class HuntResultResponseFormatter : IMessagePackFormatter<HuntResultResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, HuntResultResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public HuntResultResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
