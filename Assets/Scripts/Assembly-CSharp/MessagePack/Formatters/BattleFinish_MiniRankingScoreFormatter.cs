namespace MessagePack.Formatters
{
	public sealed class BattleFinish_MiniRankingScoreFormatter : IMessagePackFormatter<BattleFinish.MiniRankingScore>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, BattleFinish.MiniRankingScore value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public BattleFinish.MiniRankingScore Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
