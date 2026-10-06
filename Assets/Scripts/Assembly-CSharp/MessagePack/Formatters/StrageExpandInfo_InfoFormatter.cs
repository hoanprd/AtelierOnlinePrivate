namespace MessagePack.Formatters
{
	public sealed class StrageExpandInfo_InfoFormatter : IMessagePackFormatter<StrageExpandInfo.Info>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, StrageExpandInfo.Info value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public StrageExpandInfo.Info Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
