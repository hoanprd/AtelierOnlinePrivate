namespace MessagePack.Formatters
{
	public sealed class EquipFavoListFormatter : IMessagePackFormatter<EquipFavoList>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, EquipFavoList value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public EquipFavoList Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
