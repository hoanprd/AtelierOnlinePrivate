namespace MessagePack.Formatters
{
	public sealed class RpcEnemyCheckFormatter : IMessagePackFormatter<RpcEnemyCheck>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcEnemyCheck value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcEnemyCheck Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
