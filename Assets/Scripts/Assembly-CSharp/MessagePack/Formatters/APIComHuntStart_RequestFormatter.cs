namespace MessagePack.Formatters
{
	public sealed class APIComHuntStart_RequestFormatter : IMessagePackFormatter<APIComHuntStart.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIComHuntStart.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIComHuntStart.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
