namespace MessagePack.Formatters
{
	public sealed class RpcBattleContinueFormatter : IMessagePackFormatter<RpcBattleContinue>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcBattleContinue value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcBattleContinue Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
