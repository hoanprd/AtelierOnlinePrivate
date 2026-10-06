namespace MessagePack.Formatters
{
	public sealed class GachaInfoListFormatter : IMessagePackFormatter<GachaInfoList>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, GachaInfoList value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public GachaInfoList Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
