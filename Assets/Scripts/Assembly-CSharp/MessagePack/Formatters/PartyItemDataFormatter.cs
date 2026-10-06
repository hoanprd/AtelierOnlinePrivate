namespace MessagePack.Formatters
{
	public sealed class PartyItemDataFormatter : IMessagePackFormatter<PartyItemData>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, PartyItemData value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public PartyItemData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
