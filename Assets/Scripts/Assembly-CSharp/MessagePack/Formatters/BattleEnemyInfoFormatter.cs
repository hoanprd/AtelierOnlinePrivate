namespace MessagePack.Formatters
{
	public sealed class BattleEnemyInfoFormatter : IMessagePackFormatter<BattleEnemyInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, BattleEnemyInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public BattleEnemyInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
