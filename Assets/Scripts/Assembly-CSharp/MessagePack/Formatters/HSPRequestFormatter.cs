namespace MessagePack.Formatters
{
	public sealed class HSPRequestFormatter : IMessagePackFormatter<HSPRequest>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, HSPRequest value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public HSPRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
