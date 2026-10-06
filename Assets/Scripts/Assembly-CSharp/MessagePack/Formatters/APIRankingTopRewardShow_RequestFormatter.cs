namespace MessagePack.Formatters
{
	public sealed class APIRankingTopRewardShow_RequestFormatter : IMessagePackFormatter<APIRankingTopRewardShow.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIRankingTopRewardShow.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIRankingTopRewardShow.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
