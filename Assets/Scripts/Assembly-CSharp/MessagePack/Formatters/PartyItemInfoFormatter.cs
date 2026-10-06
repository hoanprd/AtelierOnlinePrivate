namespace MessagePack.Formatters
{
	public sealed class PartyItemInfoFormatter : IMessagePackFormatter<PartyItemInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, PartyItemInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public PartyItemInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
