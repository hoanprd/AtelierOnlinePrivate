namespace MessagePack.Formatters
{
	public sealed class HuntStartResponseFormatter : IMessagePackFormatter<HuntStartResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, HuntStartResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public HuntStartResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
