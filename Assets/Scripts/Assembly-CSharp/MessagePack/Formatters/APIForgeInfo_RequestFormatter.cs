namespace MessagePack.Formatters
{
	public sealed class APIForgeInfo_RequestFormatter : IMessagePackFormatter<APIForgeInfo.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIForgeInfo.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIForgeInfo.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
