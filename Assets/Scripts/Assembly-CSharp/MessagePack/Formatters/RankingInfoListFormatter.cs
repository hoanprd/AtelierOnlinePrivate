namespace MessagePack.Formatters
{
	public sealed class RankingInfoListFormatter : IMessagePackFormatter<RankingInfoList>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RankingInfoList value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RankingInfoList Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
