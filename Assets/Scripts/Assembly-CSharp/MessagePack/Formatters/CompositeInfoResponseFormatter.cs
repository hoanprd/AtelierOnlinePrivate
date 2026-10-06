namespace MessagePack.Formatters
{
	public sealed class CompositeInfoResponseFormatter : IMessagePackFormatter<CompositeInfoResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, CompositeInfoResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public CompositeInfoResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
