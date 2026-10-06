namespace MessagePack.Formatters
{
	public sealed class RankingPartyInfoDataFormatter : IMessagePackFormatter<RankingPartyInfoData>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RankingPartyInfoData value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RankingPartyInfoData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
