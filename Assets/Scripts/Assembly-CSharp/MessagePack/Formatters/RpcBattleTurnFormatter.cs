namespace MessagePack.Formatters
{
	public sealed class RpcBattleTurnFormatter : IMessagePackFormatter<RpcBattleTurn>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcBattleTurn value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcBattleTurn Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
