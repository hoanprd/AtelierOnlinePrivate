namespace MessagePack.Formatters
{
	public sealed class APIComProductRegisterAge_RequestFormatter : IMessagePackFormatter<APIComProductRegisterAge.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIComProductRegisterAge.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIComProductRegisterAge.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
