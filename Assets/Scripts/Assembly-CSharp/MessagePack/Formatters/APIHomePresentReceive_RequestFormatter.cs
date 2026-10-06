namespace MessagePack.Formatters
{
	public sealed class APIHomePresentReceive_RequestFormatter : IMessagePackFormatter<APIHomePresentReceive.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIHomePresentReceive.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIHomePresentReceive.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
