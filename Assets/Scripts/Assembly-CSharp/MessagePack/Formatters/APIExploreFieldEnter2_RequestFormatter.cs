namespace MessagePack.Formatters
{
	public sealed class APIExploreFieldEnter2_RequestFormatter : IMessagePackFormatter<APIExploreFieldEnter2.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIExploreFieldEnter2.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIExploreFieldEnter2.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
