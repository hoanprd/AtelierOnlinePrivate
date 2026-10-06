namespace MessagePack.Formatters
{
	public sealed class CharaStatusFormatter : IMessagePackFormatter<CharaStatus>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, CharaStatus value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public CharaStatus Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
