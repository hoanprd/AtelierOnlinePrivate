namespace MessagePack.Formatters
{
	public sealed class ExploreRoomCreateFormatter : IMessagePackFormatter<ExploreRoomCreate>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ExploreRoomCreate value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ExploreRoomCreate Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
