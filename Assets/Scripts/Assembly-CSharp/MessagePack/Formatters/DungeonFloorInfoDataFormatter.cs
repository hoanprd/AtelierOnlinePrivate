namespace MessagePack.Formatters
{
	public sealed class DungeonFloorInfoDataFormatter : IMessagePackFormatter<DungeonFloorInfoData>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, DungeonFloorInfoData value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public DungeonFloorInfoData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
