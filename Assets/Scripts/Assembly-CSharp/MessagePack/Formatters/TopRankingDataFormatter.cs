namespace MessagePack.Formatters
{
	public sealed class TopRankingDataFormatter : IMessagePackFormatter<TopRankingData>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, TopRankingData value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public TopRankingData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
