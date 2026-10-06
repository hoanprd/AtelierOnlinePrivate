namespace MessagePack.Formatters
{
	public sealed class DungeonFieldDataFormatter : IMessagePackFormatter<DungeonFieldData>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, DungeonFieldData value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public DungeonFieldData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
