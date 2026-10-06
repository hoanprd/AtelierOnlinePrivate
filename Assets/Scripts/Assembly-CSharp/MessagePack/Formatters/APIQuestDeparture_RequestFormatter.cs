namespace MessagePack.Formatters
{
	public sealed class APIQuestDeparture_RequestFormatter : IMessagePackFormatter<APIQuestDeparture.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIQuestDeparture.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIQuestDeparture.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
