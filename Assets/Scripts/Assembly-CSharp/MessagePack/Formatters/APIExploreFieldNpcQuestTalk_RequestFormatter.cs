namespace MessagePack.Formatters
{
	public sealed class APIExploreFieldNpcQuestTalk_RequestFormatter : IMessagePackFormatter<APIExploreFieldNpcQuestTalk.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIExploreFieldNpcQuestTalk.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIExploreFieldNpcQuestTalk.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
