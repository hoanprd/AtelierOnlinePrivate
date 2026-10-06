namespace MessagePack.Formatters
{
	public sealed class CompositeInfoFormatter : IMessagePackFormatter<CompositeInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, CompositeInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public CompositeInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
