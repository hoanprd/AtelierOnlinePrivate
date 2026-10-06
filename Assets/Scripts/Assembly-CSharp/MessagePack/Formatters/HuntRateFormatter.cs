namespace MessagePack.Formatters
{
	public sealed class HuntRateFormatter : IMessagePackFormatter<HuntRate>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, HuntRate value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public HuntRate Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
