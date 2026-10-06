namespace MessagePack.Formatters
{
	public sealed class RespireResultFormatter : IMessagePackFormatter<RespireResult>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RespireResult value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RespireResult Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
