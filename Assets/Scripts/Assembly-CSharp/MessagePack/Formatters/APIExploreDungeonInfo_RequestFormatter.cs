namespace MessagePack.Formatters
{
	public sealed class APIExploreDungeonInfo_RequestFormatter : IMessagePackFormatter<APIExploreDungeonInfo.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIExploreDungeonInfo.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIExploreDungeonInfo.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
