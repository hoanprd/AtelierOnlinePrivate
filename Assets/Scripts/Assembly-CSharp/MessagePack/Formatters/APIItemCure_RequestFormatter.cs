namespace MessagePack.Formatters
{
	public sealed class APIItemCure_RequestFormatter : IMessagePackFormatter<APIItemCure.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIItemCure.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIItemCure.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
