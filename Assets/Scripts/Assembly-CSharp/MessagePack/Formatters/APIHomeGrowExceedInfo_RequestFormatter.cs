namespace MessagePack.Formatters
{
	public sealed class APIHomeGrowExceedInfo_RequestFormatter : IMessagePackFormatter<APIHomeGrowExceedInfo.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIHomeGrowExceedInfo.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIHomeGrowExceedInfo.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
