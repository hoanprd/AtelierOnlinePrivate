namespace MessagePack.Formatters
{
	public sealed class APIRankingPartyInfoShow_RequestFormatter : IMessagePackFormatter<APIRankingPartyInfoShow.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIRankingPartyInfoShow.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIRankingPartyInfoShow.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
