namespace MessagePack.Formatters
{
	public sealed class CharaDetailFormatter : IMessagePackFormatter<CharaDetail>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, CharaDetail value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public CharaDetail Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
