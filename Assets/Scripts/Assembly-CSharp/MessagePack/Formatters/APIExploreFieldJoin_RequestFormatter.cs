namespace MessagePack.Formatters
{
	public sealed class APIExploreFieldJoin_RequestFormatter : IMessagePackFormatter<APIExploreFieldJoin.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIExploreFieldJoin.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIExploreFieldJoin.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
