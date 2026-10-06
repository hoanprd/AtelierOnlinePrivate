namespace MessagePack.Formatters
{
	public sealed class BattleFinish_EnemySpotFormatter : IMessagePackFormatter<BattleFinish.EnemySpot>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, BattleFinish.EnemySpot value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public BattleFinish.EnemySpot Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
