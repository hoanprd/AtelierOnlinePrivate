namespace MessagePack.Formatters
{
	public sealed class APIHomePartyEquipSubInfo_RequestFormatter : IMessagePackFormatter<APIHomePartyEquipSubInfo.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIHomePartyEquipSubInfo.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIHomePartyEquipSubInfo.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
