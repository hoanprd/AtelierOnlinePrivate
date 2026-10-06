namespace MessagePack.Formatters
{
	public sealed class APIItemSprinkle_RequestFormatter : IMessagePackFormatter<APIItemSprinkle.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIItemSprinkle.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIItemSprinkle.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
