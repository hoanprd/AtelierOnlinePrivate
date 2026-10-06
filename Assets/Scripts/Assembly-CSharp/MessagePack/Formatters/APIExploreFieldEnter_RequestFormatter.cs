namespace MessagePack.Formatters
{
	public sealed class APIExploreFieldEnter_RequestFormatter : IMessagePackFormatter<APIExploreFieldEnter.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIExploreFieldEnter.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIExploreFieldEnter.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
