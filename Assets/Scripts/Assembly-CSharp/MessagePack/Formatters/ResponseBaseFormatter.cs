namespace MessagePack.Formatters
{
	public sealed class ResponseBaseFormatter : IMessagePackFormatter<ResponseBase>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ResponseBase value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ResponseBase Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
