namespace MessagePack.Formatters
{
	public sealed class APIExploreDungeonCreate_RequestFormatter : IMessagePackFormatter<APIExploreDungeonCreate.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIExploreDungeonCreate.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIExploreDungeonCreate.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
