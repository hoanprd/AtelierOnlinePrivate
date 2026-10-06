namespace MessagePack.Formatters
{
	public sealed class RpcBattleContinueJoinFormatter : IMessagePackFormatter<RpcBattleContinueJoin>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcBattleContinueJoin value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcBattleContinueJoin Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
