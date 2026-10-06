namespace MessagePack.Formatters
{
	public sealed class ResponseDataCommonFormatter : IMessagePackFormatter<ResponseDataCommon>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ResponseDataCommon value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ResponseDataCommon Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
