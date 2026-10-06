namespace MessagePack.Formatters
{
	public sealed class CompositeMaterialFormatter : IMessagePackFormatter<CompositeMaterial>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, CompositeMaterial value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public CompositeMaterial Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
