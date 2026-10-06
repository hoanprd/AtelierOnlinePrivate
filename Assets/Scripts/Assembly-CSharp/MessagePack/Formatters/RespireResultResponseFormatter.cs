namespace MessagePack.Formatters
{
	public sealed class RespireResultResponseFormatter : IMessagePackFormatter<RespireResultResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RespireResultResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RespireResultResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
