namespace MessagePack.Formatters
{
	public sealed class BattleFinishResponseFormatter : IMessagePackFormatter<BattleFinishResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, BattleFinishResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public BattleFinishResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
