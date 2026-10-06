namespace MessagePack.Formatters
{
	public sealed class DungeonDifficulty_QuestFormatter : IMessagePackFormatter<DungeonDifficulty.Quest>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, DungeonDifficulty.Quest value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public DungeonDifficulty.Quest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
