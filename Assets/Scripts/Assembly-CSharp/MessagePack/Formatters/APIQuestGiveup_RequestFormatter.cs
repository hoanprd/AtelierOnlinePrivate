namespace MessagePack.Formatters
{
	public sealed class APIQuestGiveup_RequestFormatter : IMessagePackFormatter<APIQuestGiveup.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIQuestGiveup.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIQuestGiveup.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
