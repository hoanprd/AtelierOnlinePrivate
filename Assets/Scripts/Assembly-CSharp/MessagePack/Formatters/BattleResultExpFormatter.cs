namespace MessagePack.Formatters
{
	public sealed class BattleResultExpFormatter : IMessagePackFormatter<BattleResultExp>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, BattleResultExp value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public BattleResultExp Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
