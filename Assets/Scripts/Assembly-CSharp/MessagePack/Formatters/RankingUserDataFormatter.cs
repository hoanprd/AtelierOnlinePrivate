namespace MessagePack.Formatters
{
	public sealed class RankingUserDataFormatter : IMessagePackFormatter<RankingUserData>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RankingUserData value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RankingUserData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
