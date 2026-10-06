namespace MessagePack.Formatters
{
	public sealed class DungeonUnlockFormatter : IMessagePackFormatter<DungeonUnlock>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, DungeonUnlock value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public DungeonUnlock Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
