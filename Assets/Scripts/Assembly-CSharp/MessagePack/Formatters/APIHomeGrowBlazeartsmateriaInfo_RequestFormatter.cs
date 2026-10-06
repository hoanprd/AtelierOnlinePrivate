namespace MessagePack.Formatters
{
	public sealed class APIHomeGrowBlazeartsmateriaInfo_RequestFormatter : IMessagePackFormatter<APIHomeGrowBlazeartsmateriaInfo.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIHomeGrowBlazeartsmateriaInfo.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIHomeGrowBlazeartsmateriaInfo.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
