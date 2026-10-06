namespace MessagePack.Formatters
{
	public sealed class SalonChooseFormatter : IMessagePackFormatter<SalonChoose>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, SalonChoose value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public SalonChoose Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
