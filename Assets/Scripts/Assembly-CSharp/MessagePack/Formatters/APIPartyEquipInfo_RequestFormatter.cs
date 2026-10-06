namespace MessagePack.Formatters
{
	public sealed class APIPartyEquipInfo_RequestFormatter : IMessagePackFormatter<APIPartyEquipInfo.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIPartyEquipInfo.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIPartyEquipInfo.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
