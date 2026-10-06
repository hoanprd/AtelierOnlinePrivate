namespace MessagePack.Formatters
{
	public sealed class APIPartyEquipChoose_RequestFormatter : IMessagePackFormatter<APIPartyEquipChoose.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIPartyEquipChoose.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIPartyEquipChoose.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
