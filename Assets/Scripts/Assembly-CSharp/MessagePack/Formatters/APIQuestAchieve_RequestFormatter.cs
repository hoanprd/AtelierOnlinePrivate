namespace MessagePack.Formatters
{
	public sealed class APIQuestAchieve_RequestFormatter : IMessagePackFormatter<APIQuestAchieve.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIQuestAchieve.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIQuestAchieve.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
