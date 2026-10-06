namespace MessagePack.Formatters
{
	public sealed class APIQuestStart_RequestFormatter : IMessagePackFormatter<APIQuestStart.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIQuestStart.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIQuestStart.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
