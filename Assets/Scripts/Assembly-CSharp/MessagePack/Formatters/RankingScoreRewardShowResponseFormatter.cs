namespace MessagePack.Formatters
{
	public sealed class RankingScoreRewardShowResponseFormatter : IMessagePackFormatter<RankingScoreRewardShowResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RankingScoreRewardShowResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RankingScoreRewardShowResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
