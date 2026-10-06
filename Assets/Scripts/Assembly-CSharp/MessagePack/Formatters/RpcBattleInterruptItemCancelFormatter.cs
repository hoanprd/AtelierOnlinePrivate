namespace MessagePack.Formatters
{
	public sealed class RpcBattleInterruptItemCancelFormatter : IMessagePackFormatter<RpcBattleInterruptItemCancel>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcBattleInterruptItemCancel value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcBattleInterruptItemCancel Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
