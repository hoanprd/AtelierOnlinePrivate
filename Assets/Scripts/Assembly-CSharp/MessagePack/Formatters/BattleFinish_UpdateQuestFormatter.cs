namespace MessagePack.Formatters
{
	public sealed class BattleFinish_UpdateQuestFormatter : IMessagePackFormatter<BattleFinish.UpdateQuest>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, BattleFinish.UpdateQuest value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public BattleFinish.UpdateQuest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
