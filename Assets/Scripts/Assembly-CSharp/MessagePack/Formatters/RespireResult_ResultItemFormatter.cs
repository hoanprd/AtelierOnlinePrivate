namespace MessagePack.Formatters
{
	public sealed class RespireResult_ResultItemFormatter : IMessagePackFormatter<RespireResult.ResultItem>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RespireResult.ResultItem value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RespireResult.ResultItem Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
