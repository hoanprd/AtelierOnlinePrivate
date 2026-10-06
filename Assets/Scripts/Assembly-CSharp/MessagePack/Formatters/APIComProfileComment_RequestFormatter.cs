namespace MessagePack.Formatters
{
	public sealed class APIComProfileComment_RequestFormatter : IMessagePackFormatter<APIComProfileComment.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIComProfileComment.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIComProfileComment.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
