namespace MessagePack.Formatters
{
	public sealed class DailyMissionInfoFormatter : IMessagePackFormatter<DailyMissionInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, DailyMissionInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public DailyMissionInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
