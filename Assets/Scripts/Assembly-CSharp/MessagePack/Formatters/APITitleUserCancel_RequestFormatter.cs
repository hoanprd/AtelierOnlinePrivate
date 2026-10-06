namespace MessagePack.Formatters
{
	public sealed class APITitleUserCancel_RequestFormatter : IMessagePackFormatter<APITitleUserCancel.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APITitleUserCancel.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APITitleUserCancel.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
