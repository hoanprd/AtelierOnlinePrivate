namespace MessagePack.Formatters
{
	public sealed class APIRankingTopShow_RequestFormatter : IMessagePackFormatter<APIRankingTopShow.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIRankingTopShow.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIRankingTopShow.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
