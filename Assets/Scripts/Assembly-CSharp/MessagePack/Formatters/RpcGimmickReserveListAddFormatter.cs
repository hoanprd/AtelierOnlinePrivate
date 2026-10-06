namespace MessagePack.Formatters
{
	public sealed class RpcGimmickReserveListAddFormatter : IMessagePackFormatter<RpcGimmickReserveListAdd>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcGimmickReserveListAdd value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcGimmickReserveListAdd Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
