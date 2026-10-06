namespace MessagePack.Formatters
{
	public sealed class CharaSpecFormatter : IMessagePackFormatter<CharaSpec>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, CharaSpec value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public CharaSpec Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
