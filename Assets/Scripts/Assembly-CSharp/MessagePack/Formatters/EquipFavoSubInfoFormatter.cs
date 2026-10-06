namespace MessagePack.Formatters
{
	public sealed class EquipFavoSubInfoFormatter : IMessagePackFormatter<EquipFavoSubInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, EquipFavoSubInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public EquipFavoSubInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
