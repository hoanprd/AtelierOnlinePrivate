namespace MessagePack.Formatters
{
	public sealed class APIQuestShow_RequestFormatter : IMessagePackFormatter<APIQuestShow.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIQuestShow.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIQuestShow.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
