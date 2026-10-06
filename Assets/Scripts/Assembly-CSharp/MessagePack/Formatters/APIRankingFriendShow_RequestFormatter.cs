namespace MessagePack.Formatters
{
	public sealed class APIRankingFriendShow_RequestFormatter : IMessagePackFormatter<APIRankingFriendShow.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIRankingFriendShow.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIRankingFriendShow.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
