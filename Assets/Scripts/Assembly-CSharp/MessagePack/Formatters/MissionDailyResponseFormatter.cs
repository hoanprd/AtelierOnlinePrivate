namespace MessagePack.Formatters
{
	public sealed class MissionDailyResponseFormatter : IMessagePackFormatter<MissionDailyResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, MissionDailyResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public MissionDailyResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
