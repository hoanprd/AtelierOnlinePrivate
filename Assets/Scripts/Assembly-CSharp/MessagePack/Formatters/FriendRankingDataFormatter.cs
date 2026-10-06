namespace MessagePack.Formatters
{
	public sealed class FriendRankingDataFormatter : IMessagePackFormatter<FriendRankingData>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, FriendRankingData value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public FriendRankingData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
