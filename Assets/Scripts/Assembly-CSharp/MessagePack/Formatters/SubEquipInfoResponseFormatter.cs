namespace MessagePack.Formatters
{
	public sealed class SubEquipInfoResponseFormatter : IMessagePackFormatter<SubEquipInfoResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, SubEquipInfoResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public SubEquipInfoResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
