namespace MessagePack.Formatters
{
	public sealed class RpcRequestProfileFormatter : IMessagePackFormatter<RpcRequestProfile>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcRequestProfile value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcRequestProfile Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
