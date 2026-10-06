namespace MessagePack.Formatters
{
	public sealed class PresentReceiveResponseFormatter : IMessagePackFormatter<PresentReceiveResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, PresentReceiveResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public PresentReceiveResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
