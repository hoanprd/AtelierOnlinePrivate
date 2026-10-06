namespace MessagePack.Formatters
{
	public sealed class RpcBattleInterruptItemFormatter : IMessagePackFormatter<RpcBattleInterruptItem>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcBattleInterruptItem value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcBattleInterruptItem Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
