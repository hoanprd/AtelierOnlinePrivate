namespace MessagePack.Formatters
{
	public sealed class FairyPickResultFormatter : IMessagePackFormatter<FairyPickResult>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, FairyPickResult value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public FairyPickResult Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
