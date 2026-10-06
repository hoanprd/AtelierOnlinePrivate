namespace MessagePack.Formatters
{
	public sealed class APIPartyMemberChoose_RequestFormatter : IMessagePackFormatter<APIPartyMemberChoose.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIPartyMemberChoose.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIPartyMemberChoose.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
