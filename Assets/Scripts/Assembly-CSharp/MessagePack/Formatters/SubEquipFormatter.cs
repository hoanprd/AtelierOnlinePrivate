namespace MessagePack.Formatters
{
	public sealed class SubEquipFormatter : IMessagePackFormatter<SubEquip>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, SubEquip value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public SubEquip Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
