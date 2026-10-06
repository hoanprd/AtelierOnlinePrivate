namespace MessagePack.Formatters
{
	public sealed class DungeonDifficultyFormatter : IMessagePackFormatter<DungeonDifficulty>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, DungeonDifficulty value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public DungeonDifficulty Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
