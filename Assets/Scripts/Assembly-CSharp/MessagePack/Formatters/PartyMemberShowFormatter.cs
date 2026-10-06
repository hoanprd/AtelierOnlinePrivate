namespace MessagePack.Formatters
{
	public sealed class PartyMemberShowFormatter : IMessagePackFormatter<PartyMemberShow>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, PartyMemberShow value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public PartyMemberShow Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
