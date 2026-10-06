namespace MessagePack.Formatters
{
	public sealed class APIQuestDeliver_RequestFormatter : IMessagePackFormatter<APIQuestDeliver.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIQuestDeliver.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIQuestDeliver.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
