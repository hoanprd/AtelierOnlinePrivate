namespace MessagePack.Formatters
{
	public sealed class RpcExqCancelOrderDataFormatter : IMessagePackFormatter<RpcExqCancelOrderData>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcExqCancelOrderData value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcExqCancelOrderData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
