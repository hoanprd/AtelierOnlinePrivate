namespace MessagePack.Formatters
{
	public sealed class APIComHuntResult_RequestFormatter : IMessagePackFormatter<APIComHuntResult.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIComHuntResult.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIComHuntResult.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
