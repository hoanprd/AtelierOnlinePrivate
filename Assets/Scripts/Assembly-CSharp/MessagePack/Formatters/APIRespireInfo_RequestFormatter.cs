namespace MessagePack.Formatters
{
	public sealed class APIRespireInfo_RequestFormatter : IMessagePackFormatter<APIRespireInfo.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIRespireInfo.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIRespireInfo.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
