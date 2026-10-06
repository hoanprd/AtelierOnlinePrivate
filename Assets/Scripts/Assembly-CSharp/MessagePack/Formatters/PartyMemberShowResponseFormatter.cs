namespace MessagePack.Formatters
{
	public sealed class PartyMemberShowResponseFormatter : IMessagePackFormatter<PartyMemberShowResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, PartyMemberShowResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public PartyMemberShowResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
