namespace MessagePack.Formatters
{
	public sealed class BattleFinish_UpdateQuest_AcheiveFormatter : IMessagePackFormatter<BattleFinish.UpdateQuest.Acheive>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, BattleFinish.UpdateQuest.Acheive value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public BattleFinish.UpdateQuest.Acheive Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
