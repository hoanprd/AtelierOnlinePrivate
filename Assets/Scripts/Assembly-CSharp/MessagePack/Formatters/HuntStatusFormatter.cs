namespace MessagePack.Formatters
{
	public sealed class HuntStatusFormatter : IMessagePackFormatter<HuntStatus>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, HuntStatus value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public HuntStatus Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
