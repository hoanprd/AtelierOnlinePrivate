namespace MessagePack.Formatters
{
	public sealed class PartyEquipFavoEraseResponseFormatter : IMessagePackFormatter<PartyEquipFavoEraseResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, PartyEquipFavoEraseResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public PartyEquipFavoEraseResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
