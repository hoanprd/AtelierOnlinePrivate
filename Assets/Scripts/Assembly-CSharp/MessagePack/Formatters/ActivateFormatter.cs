namespace MessagePack.Formatters
{
	public sealed class ActivateFormatter : IMessagePackFormatter<Activate>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, Activate value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public Activate Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
