namespace MessagePack.Formatters
{
	public sealed class MiniRankingBoostInfoFormatter : IMessagePackFormatter<MiniRankingBoostInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, MiniRankingBoostInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public MiniRankingBoostInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
