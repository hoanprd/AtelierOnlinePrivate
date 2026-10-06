namespace MessagePack.Formatters
{
	public sealed class APIExploreFieldDestroy_RequestFormatter : IMessagePackFormatter<APIExploreFieldDestroy.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIExploreFieldDestroy.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIExploreFieldDestroy.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
