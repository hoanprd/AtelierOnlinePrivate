namespace MessagePack.Formatters
{
	public sealed class APIExploreFieldGateStamp_RequestFormatter : IMessagePackFormatter<APIExploreFieldGateStamp.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIExploreFieldGateStamp.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIExploreFieldGateStamp.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
