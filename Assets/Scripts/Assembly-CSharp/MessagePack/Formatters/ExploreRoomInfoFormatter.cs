namespace MessagePack.Formatters
{
	public sealed class ExploreRoomInfoFormatter : IMessagePackFormatter<ExploreRoomInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ExploreRoomInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ExploreRoomInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
