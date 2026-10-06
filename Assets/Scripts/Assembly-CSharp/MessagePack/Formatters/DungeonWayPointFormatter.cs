namespace MessagePack.Formatters
{
	public sealed class DungeonWayPointFormatter : IMessagePackFormatter<DungeonWayPoint>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, DungeonWayPoint value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public DungeonWayPoint Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
