namespace MessagePack.Formatters
{
	public sealed class APIPartyEquipFavErase_RequestFormatter : IMessagePackFormatter<APIPartyEquipFavErase.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIPartyEquipFavErase.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIPartyEquipFavErase.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
