namespace MessagePack.Formatters
{
	public sealed class RpcBattleUseItemFormatter : IMessagePackFormatter<RpcBattleUseItem>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcBattleUseItem value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcBattleUseItem Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
