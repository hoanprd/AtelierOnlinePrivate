namespace MessagePack.Formatters
{
	public sealed class APIPartyMemberShow_RequestFormatter : IMessagePackFormatter<APIPartyMemberShow.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIPartyMemberShow.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIPartyMemberShow.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
