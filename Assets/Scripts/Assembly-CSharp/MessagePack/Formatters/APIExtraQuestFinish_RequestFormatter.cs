namespace MessagePack.Formatters
{
	public sealed class APIExtraQuestFinish_RequestFormatter : IMessagePackFormatter<APIExtraQuestFinish.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIExtraQuestFinish.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIExtraQuestFinish.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
