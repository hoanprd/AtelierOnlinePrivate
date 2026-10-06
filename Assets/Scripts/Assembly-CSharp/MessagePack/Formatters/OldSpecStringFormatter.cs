namespace MessagePack.Formatters
{
	public sealed class OldSpecStringFormatter : IMessagePackFormatter<string>, IMessagePackFormatter
	{
		public static readonly OldSpecStringFormatter Instance;

		public int Serialize(ref byte[] bytes, int offset, string value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public string Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
