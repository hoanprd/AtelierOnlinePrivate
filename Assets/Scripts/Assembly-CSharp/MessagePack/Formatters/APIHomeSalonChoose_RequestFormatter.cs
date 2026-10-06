namespace MessagePack.Formatters
{
	public sealed class APIHomeSalonChoose_RequestFormatter : IMessagePackFormatter<APIHomeSalonChoose.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIHomeSalonChoose.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIHomeSalonChoose.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
