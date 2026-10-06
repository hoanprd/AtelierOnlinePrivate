namespace MessagePack.Formatters
{
	public sealed class APIHomePartyEquipSubChoose_RequestFormatter : IMessagePackFormatter<APIHomePartyEquipSubChoose.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIHomePartyEquipSubChoose.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIHomePartyEquipSubChoose.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
