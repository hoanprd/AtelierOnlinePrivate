namespace MessagePack.Formatters
{
	public sealed class DailyMissionInfo_InfoFormatter : IMessagePackFormatter<DailyMissionInfo.Info>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, DailyMissionInfo.Info value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public DailyMissionInfo.Info Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
