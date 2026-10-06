namespace MessagePack.Formatters
{
	public sealed class APIPartyEquipFavInfo_RequestFormatter : IMessagePackFormatter<APIPartyEquipFavInfo.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIPartyEquipFavInfo.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIPartyEquipFavInfo.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
