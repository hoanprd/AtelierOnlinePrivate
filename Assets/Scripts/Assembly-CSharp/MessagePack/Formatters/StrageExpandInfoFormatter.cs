namespace MessagePack.Formatters
{
	public sealed class StrageExpandInfoFormatter : IMessagePackFormatter<StrageExpandInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, StrageExpandInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public StrageExpandInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
