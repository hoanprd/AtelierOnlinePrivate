namespace MessagePack.Formatters
{
	public sealed class PartyEquipFavoListResponseFormatter : IMessagePackFormatter<PartyEquipFavoListResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, PartyEquipFavoListResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public PartyEquipFavoListResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
