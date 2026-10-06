namespace MessagePack.Formatters
{
	public sealed class RankingPartyInfoShowResponseFormatter : IMessagePackFormatter<RankingPartyInfoShowResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RankingPartyInfoShowResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RankingPartyInfoShowResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
