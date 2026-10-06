namespace MessagePack.Formatters
{
	public sealed class APIExploreVillageHeal_RequestFormatter : IMessagePackFormatter<APIExploreVillageHeal.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIExploreVillageHeal.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIExploreVillageHeal.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
