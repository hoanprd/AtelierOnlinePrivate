namespace MessagePack.Formatters
{
	public sealed class RpcBattleTurnCountUpdateFormatter : IMessagePackFormatter<RpcBattleTurnCountUpdate>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcBattleTurnCountUpdate value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcBattleTurnCountUpdate Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
