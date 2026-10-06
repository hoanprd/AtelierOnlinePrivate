namespace MessagePack.Formatters
{
	public sealed class AlchemyAlterResponseFormatter : IMessagePackFormatter<AlchemyAlterResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, AlchemyAlterResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public AlchemyAlterResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
