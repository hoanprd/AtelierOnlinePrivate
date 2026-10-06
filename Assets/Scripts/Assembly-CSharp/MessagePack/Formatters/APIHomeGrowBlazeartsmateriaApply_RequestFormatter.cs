namespace MessagePack.Formatters
{
	public sealed class APIHomeGrowBlazeartsmateriaApply_RequestFormatter : IMessagePackFormatter<APIHomeGrowBlazeartsmateriaApply.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIHomeGrowBlazeartsmateriaApply.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIHomeGrowBlazeartsmateriaApply.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
