namespace MessagePack.Formatters
{
	public sealed class RestoreFormatter : IMessagePackFormatter<Restore>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, Restore value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public Restore Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
