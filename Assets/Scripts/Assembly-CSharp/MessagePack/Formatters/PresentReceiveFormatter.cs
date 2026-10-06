namespace MessagePack.Formatters
{
	public sealed class PresentReceiveFormatter : IMessagePackFormatter<PresentReceive>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, PresentReceive value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public PresentReceive Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
