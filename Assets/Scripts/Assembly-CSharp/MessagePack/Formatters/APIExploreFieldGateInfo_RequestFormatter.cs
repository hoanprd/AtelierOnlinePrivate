namespace MessagePack.Formatters
{
	public sealed class APIExploreFieldGateInfo_RequestFormatter : IMessagePackFormatter<APIExploreFieldGateInfo.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIExploreFieldGateInfo.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIExploreFieldGateInfo.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
