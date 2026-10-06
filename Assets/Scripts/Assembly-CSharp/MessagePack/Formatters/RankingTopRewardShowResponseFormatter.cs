namespace MessagePack.Formatters
{
	public sealed class RankingTopRewardShowResponseFormatter : IMessagePackFormatter<RankingTopRewardShowResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RankingTopRewardShowResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RankingTopRewardShowResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
