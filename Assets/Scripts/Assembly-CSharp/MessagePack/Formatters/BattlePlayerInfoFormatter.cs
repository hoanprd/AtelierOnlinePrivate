namespace MessagePack.Formatters
{
	public sealed class BattlePlayerInfoFormatter : IMessagePackFormatter<BattlePlayerInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, BattlePlayerInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public BattlePlayerInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
