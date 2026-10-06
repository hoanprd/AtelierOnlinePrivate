namespace MessagePack.Formatters
{
	public sealed class APIHomePresentReceive_Request_IDDataFormatter : IMessagePackFormatter<APIHomePresentReceive.Request.IDData>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIHomePresentReceive.Request.IDData value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIHomePresentReceive.Request.IDData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
