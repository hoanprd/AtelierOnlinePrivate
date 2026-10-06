namespace MessagePack.Formatters
{
	public sealed class DungeonFieldDataResponseFormatter : IMessagePackFormatter<DungeonFieldDataResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, DungeonFieldDataResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public DungeonFieldDataResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
