namespace MessagePack.Formatters
{
	public sealed class APIHomeGateInfo_RequestFormatter : IMessagePackFormatter<APIHomeGateInfo.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIHomeGateInfo.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIHomeGateInfo.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
