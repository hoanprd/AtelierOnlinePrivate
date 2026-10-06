namespace MessagePack.Formatters
{
	public sealed class APIComTutoFinish_RequestFormatter : IMessagePackFormatter<APIComTutoFinish.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIComTutoFinish.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIComTutoFinish.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
