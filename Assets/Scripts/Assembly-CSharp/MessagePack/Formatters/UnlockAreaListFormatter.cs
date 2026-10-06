namespace MessagePack.Formatters
{
	public sealed class UnlockAreaListFormatter : IMessagePackFormatter<UnlockAreaList>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, UnlockAreaList value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public UnlockAreaList Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
