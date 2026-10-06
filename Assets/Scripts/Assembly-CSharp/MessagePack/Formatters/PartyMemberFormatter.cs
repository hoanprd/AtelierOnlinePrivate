namespace MessagePack.Formatters
{
	public sealed class PartyMemberFormatter : IMessagePackFormatter<PartyMember>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, PartyMember value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public PartyMember Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
