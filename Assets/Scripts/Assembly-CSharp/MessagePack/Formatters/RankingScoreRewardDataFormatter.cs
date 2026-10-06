namespace MessagePack.Formatters
{
	public sealed class RankingScoreRewardDataFormatter : IMessagePackFormatter<RankingScoreRewardData>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RankingScoreRewardData value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RankingScoreRewardData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
