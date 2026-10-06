namespace MessagePack.Formatters
{
	public sealed class RespireInfoResponseFormatter : IMessagePackFormatter<RespireInfoResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RespireInfoResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RespireInfoResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
