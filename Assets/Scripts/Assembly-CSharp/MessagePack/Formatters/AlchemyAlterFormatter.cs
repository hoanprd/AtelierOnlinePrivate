namespace MessagePack.Formatters
{
	public sealed class AlchemyAlterFormatter : IMessagePackFormatter<AlchemyAlter>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, AlchemyAlter value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public AlchemyAlter Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
