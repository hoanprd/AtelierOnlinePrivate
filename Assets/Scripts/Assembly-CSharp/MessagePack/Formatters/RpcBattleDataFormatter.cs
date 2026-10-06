namespace MessagePack.Formatters
{
	public sealed class RpcBattleDataFormatter : IMessagePackFormatter<RpcBattleData>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcBattleData value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcBattleData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
