namespace MessagePack.Formatters
{
	public sealed class APIItemCure_Request_ItemFormatter : IMessagePackFormatter<APIItemCure.Request.Item>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIItemCure.Request.Item value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIItemCure.Request.Item Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
