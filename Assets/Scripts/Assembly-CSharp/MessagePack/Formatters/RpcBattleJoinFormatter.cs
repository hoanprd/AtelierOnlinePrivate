namespace MessagePack.Formatters
{
	public sealed class RpcBattleJoinFormatter : IMessagePackFormatter<RpcBattleJoin>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcBattleJoin value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcBattleJoin Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
