namespace MessagePack.Formatters
{
	public sealed class HuntFormFormatter : IMessagePackFormatter<HuntForm>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, HuntForm value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public HuntForm Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
