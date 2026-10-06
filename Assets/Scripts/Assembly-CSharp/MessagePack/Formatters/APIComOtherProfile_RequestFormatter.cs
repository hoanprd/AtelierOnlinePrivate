namespace MessagePack.Formatters
{
	public sealed class APIComOtherProfile_RequestFormatter : IMessagePackFormatter<APIComOtherProfile.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIComOtherProfile.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIComOtherProfile.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
