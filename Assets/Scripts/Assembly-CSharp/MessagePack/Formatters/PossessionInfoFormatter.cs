namespace MessagePack.Formatters
{
	public sealed class PossessionInfoFormatter : IMessagePackFormatter<PossessionInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, PossessionInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public PossessionInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
