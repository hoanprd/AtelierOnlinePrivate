namespace MessagePack.Formatters
{
	public sealed class APIPartyItemChoose_RequestFormatter : IMessagePackFormatter<APIPartyItemChoose.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIPartyItemChoose.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIPartyItemChoose.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
