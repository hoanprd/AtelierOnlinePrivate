namespace MessagePack.Formatters
{
	public sealed class PresentCharaInfoFormatter : IMessagePackFormatter<PresentCharaInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, PresentCharaInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public PresentCharaInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
