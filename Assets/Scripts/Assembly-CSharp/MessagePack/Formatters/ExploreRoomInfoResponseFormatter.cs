namespace MessagePack.Formatters
{
	public sealed class ExploreRoomInfoResponseFormatter : IMessagePackFormatter<ExploreRoomInfoResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ExploreRoomInfoResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ExploreRoomInfoResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
