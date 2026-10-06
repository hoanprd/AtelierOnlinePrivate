namespace MessagePack.Formatters
{
	public sealed class RpcBattleEscapeRemoveFormatter : IMessagePackFormatter<RpcBattleEscapeRemove>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcBattleEscapeRemove value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcBattleEscapeRemove Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
