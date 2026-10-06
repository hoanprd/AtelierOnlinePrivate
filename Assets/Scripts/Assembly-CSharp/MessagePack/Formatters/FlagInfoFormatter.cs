namespace MessagePack.Formatters
{
	public sealed class FlagInfoFormatter : IMessagePackFormatter<FlagInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, FlagInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public FlagInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
