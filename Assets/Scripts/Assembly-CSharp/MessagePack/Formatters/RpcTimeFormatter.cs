namespace MessagePack.Formatters
{
	public sealed class RpcTimeFormatter : IMessagePackFormatter<RpcTime>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcTime value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcTime Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
