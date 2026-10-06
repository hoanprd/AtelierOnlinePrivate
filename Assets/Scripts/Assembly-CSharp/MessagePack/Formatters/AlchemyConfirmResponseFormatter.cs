namespace MessagePack.Formatters
{
	public sealed class AlchemyConfirmResponseFormatter : IMessagePackFormatter<AlchemyConfirmResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, AlchemyConfirmResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public AlchemyConfirmResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
