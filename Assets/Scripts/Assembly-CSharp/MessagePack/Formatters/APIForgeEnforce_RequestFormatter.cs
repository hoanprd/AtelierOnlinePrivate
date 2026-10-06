namespace MessagePack.Formatters
{
	public sealed class APIForgeEnforce_RequestFormatter : IMessagePackFormatter<APIForgeEnforce.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIForgeEnforce.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIForgeEnforce.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
