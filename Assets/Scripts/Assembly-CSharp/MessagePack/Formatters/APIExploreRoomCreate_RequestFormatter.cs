namespace MessagePack.Formatters
{
	public sealed class APIExploreRoomCreate_RequestFormatter : IMessagePackFormatter<APIExploreRoomCreate.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIExploreRoomCreate.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIExploreRoomCreate.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
