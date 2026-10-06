namespace MessagePack.Formatters
{
	public sealed class APIRankingScoreRewardShow_RequestFormatter : IMessagePackFormatter<APIRankingScoreRewardShow.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIRankingScoreRewardShow.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIRankingScoreRewardShow.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
