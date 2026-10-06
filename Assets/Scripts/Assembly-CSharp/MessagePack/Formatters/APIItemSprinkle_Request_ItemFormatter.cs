namespace MessagePack.Formatters
{
	public sealed class APIItemSprinkle_Request_ItemFormatter : IMessagePackFormatter<APIItemSprinkle.Request.Item>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIItemSprinkle.Request.Item value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIItemSprinkle.Request.Item Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
