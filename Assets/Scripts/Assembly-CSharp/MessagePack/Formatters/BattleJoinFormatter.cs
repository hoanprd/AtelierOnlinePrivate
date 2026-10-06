namespace MessagePack.Formatters
{
	public sealed class BattleJoinFormatter : IMessagePackFormatter<BattleJoin>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, BattleJoin value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public BattleJoin Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
