namespace MessagePack.Formatters
{
	public sealed class PartyItemInfo_EnableItemFormatter : IMessagePackFormatter<PartyItemInfo.EnableItem>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, PartyItemInfo.EnableItem value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public PartyItemInfo.EnableItem Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
