namespace MessagePack.Formatters
{
	public sealed class PartyEquipFavoRegisterResponseFormatter : IMessagePackFormatter<PartyEquipFavoRegisterResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, PartyEquipFavoRegisterResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public PartyEquipFavoRegisterResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
