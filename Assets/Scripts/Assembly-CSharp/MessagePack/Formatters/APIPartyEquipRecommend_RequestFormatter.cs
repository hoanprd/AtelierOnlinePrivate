namespace MessagePack.Formatters
{
	public sealed class APIPartyEquipRecommend_RequestFormatter : IMessagePackFormatter<APIPartyEquipRecommend.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIPartyEquipRecommend.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIPartyEquipRecommend.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
