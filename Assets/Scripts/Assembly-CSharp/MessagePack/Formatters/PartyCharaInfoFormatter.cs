namespace MessagePack.Formatters
{
	public sealed class PartyCharaInfoFormatter : IMessagePackFormatter<PartyCharaInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, PartyCharaInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public PartyCharaInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
