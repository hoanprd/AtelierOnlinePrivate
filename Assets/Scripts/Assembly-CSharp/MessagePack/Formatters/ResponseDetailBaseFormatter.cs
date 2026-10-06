namespace MessagePack.Formatters
{
	public sealed class ResponseDetailBaseFormatter : IMessagePackFormatter<ResponseDetailBase>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ResponseDetailBase value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ResponseDetailBase Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
