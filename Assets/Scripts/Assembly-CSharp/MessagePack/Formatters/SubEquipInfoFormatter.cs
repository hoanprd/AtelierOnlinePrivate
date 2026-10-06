namespace MessagePack.Formatters
{
	public sealed class SubEquipInfoFormatter : IMessagePackFormatter<SubEquipInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, SubEquipInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public SubEquipInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
