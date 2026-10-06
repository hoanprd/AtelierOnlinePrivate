namespace MessagePack.Formatters
{
	public sealed class BattleStartFormatter : IMessagePackFormatter<BattleStart>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, BattleStart value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public BattleStart Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
