namespace MessagePack.Formatters
{
	public sealed class RpcExqWithdrawalJoinFormatter : IMessagePackFormatter<RpcExqWithdrawalJoin>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcExqWithdrawalJoin value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcExqWithdrawalJoin Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
