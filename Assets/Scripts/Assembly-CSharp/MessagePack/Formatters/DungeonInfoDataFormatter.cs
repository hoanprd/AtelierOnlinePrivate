namespace MessagePack.Formatters
{
	public sealed class DungeonInfoDataFormatter : IMessagePackFormatter<DungeonInfoData>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, DungeonInfoData value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public DungeonInfoData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
