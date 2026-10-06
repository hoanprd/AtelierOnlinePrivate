namespace MessagePack.Formatters
{
	public sealed class UnlockGateListFormatter : IMessagePackFormatter<UnlockGateList>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, UnlockGateList value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public UnlockGateList Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
