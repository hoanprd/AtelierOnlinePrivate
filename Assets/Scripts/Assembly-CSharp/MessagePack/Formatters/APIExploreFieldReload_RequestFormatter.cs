namespace MessagePack.Formatters
{
	public sealed class APIExploreFieldReload_RequestFormatter : IMessagePackFormatter<APIExploreFieldReload.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIExploreFieldReload.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIExploreFieldReload.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
