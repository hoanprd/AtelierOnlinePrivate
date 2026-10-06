namespace MessagePack.Formatters
{
	public sealed class DungeonFloorInfoResponseFormatter : IMessagePackFormatter<DungeonFloorInfoResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, DungeonFloorInfoResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public DungeonFloorInfoResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
