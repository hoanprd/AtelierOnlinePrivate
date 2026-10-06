namespace MessagePack.Formatters
{
	public sealed class APIComFairyItem_RequestFormatter : IMessagePackFormatter<APIComFairyItem.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIComFairyItem.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIComFairyItem.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
