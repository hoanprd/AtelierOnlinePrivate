namespace MessagePack.Formatters
{
	public sealed class APIExploreRoomInfo_RequestFormatter : IMessagePackFormatter<APIExploreRoomInfo.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIExploreRoomInfo.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIExploreRoomInfo.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
