namespace MessagePack.Formatters
{
	public sealed class APIComHuntRecommend_RequestFormatter : IMessagePackFormatter<APIComHuntRecommend.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIComHuntRecommend.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIComHuntRecommend.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
