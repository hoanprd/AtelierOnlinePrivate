namespace MessagePack.Formatters
{
	public sealed class CompositeTargetFormatter : IMessagePackFormatter<CompositeTarget>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, CompositeTarget value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public CompositeTarget Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
