namespace MessagePack.Formatters
{
	public sealed class APIHomeGrowCharaShow_RequestFormatter : IMessagePackFormatter<APIHomeGrowCharaShow.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIHomeGrowCharaShow.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIHomeGrowCharaShow.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
