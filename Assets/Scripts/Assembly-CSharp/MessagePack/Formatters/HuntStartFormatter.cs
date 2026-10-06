namespace MessagePack.Formatters
{
	public sealed class HuntStartFormatter : IMessagePackFormatter<HuntStart>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, HuntStart value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public HuntStart Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
