namespace MessagePack.Formatters
{
	public sealed class APITitleUserMappingForceMapping_RequestFormatter : IMessagePackFormatter<APITitleUserMappingForceMapping.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APITitleUserMappingForceMapping.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APITitleUserMappingForceMapping.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
