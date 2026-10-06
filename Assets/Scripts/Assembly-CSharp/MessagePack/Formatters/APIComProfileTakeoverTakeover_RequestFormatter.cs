namespace MessagePack.Formatters
{
	public sealed class APIComProfileTakeoverTakeover_RequestFormatter : IMessagePackFormatter<APIComProfileTakeoverTakeover.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIComProfileTakeoverTakeover.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIComProfileTakeoverTakeover.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
