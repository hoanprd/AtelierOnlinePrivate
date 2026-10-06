namespace MessagePack.Formatters
{
	public sealed class ExploreRoomInfo_RoomInfoFormatter : IMessagePackFormatter<ExploreRoomInfo.RoomInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ExploreRoomInfo.RoomInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ExploreRoomInfo.RoomInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
