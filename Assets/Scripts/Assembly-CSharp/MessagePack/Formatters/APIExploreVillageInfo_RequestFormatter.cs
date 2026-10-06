namespace MessagePack.Formatters
{
	public sealed class APIExploreVillageInfo_RequestFormatter : IMessagePackFormatter<APIExploreVillageInfo.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIExploreVillageInfo.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIExploreVillageInfo.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
