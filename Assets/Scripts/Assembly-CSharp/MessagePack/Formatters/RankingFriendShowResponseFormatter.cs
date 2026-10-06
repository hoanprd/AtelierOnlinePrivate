namespace MessagePack.Formatters
{
	public sealed class RankingFriendShowResponseFormatter : IMessagePackFormatter<RankingFriendShowResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RankingFriendShowResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RankingFriendShowResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
