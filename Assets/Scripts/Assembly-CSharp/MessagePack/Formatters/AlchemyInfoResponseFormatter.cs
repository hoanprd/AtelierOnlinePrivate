namespace MessagePack.Formatters
{
	public sealed class AlchemyInfoResponseFormatter : IMessagePackFormatter<AlchemyInfoResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, AlchemyInfoResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public AlchemyInfoResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
