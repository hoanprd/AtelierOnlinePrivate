namespace MessagePack.Formatters
{
	public sealed class BattleFinishFormatter : IMessagePackFormatter<BattleFinish>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, BattleFinish value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public BattleFinish Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
