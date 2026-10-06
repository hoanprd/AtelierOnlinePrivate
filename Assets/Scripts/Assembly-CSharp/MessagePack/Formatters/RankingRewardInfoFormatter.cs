namespace MessagePack.Formatters
{
	public sealed class RankingRewardInfoFormatter : IMessagePackFormatter<RankingRewardInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RankingRewardInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RankingRewardInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
