namespace MessagePack.Formatters
{
	public sealed class RpcGimmickReserveListRemoveFormatter : IMessagePackFormatter<RpcGimmickReserveListRemove>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcGimmickReserveListRemove value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcGimmickReserveListRemove Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
