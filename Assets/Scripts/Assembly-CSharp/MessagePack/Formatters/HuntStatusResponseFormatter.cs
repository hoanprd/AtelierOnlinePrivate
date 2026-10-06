namespace MessagePack.Formatters
{
	public sealed class HuntStatusResponseFormatter : IMessagePackFormatter<HuntStatusResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, HuntStatusResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public HuntStatusResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
