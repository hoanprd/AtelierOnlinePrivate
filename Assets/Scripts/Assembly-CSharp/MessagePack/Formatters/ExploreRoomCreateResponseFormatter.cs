namespace MessagePack.Formatters
{
	public sealed class ExploreRoomCreateResponseFormatter : IMessagePackFormatter<ExploreRoomCreateResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ExploreRoomCreateResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ExploreRoomCreateResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
