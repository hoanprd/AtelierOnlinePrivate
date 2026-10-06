namespace MessagePack.Formatters
{
	public sealed class APIComChatMessage_RequestFormatter : IMessagePackFormatter<APIComChatMessage.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIComChatMessage.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIComChatMessage.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
