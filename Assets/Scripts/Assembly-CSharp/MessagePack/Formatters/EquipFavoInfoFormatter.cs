namespace MessagePack.Formatters
{
	public sealed class EquipFavoInfoFormatter : IMessagePackFormatter<EquipFavoInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, EquipFavoInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public EquipFavoInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
