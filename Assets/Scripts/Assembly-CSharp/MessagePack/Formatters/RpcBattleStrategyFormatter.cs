namespace MessagePack.Formatters
{
	public sealed class RpcBattleStrategyFormatter : IMessagePackFormatter<RpcBattleStrategy>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcBattleStrategy value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcBattleStrategy Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
