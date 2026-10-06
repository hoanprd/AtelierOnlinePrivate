namespace MessagePack.Formatters
{
	public sealed class APIComFlagInfo_RequestFormatter : IMessagePackFormatter<APIComFlagInfo.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIComFlagInfo.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIComFlagInfo.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
