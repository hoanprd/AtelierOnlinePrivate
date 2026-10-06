namespace MessagePack.Formatters
{
	public sealed class RankingTopShowResponseFormatter : IMessagePackFormatter<RankingTopShowResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RankingTopShowResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RankingTopShowResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
