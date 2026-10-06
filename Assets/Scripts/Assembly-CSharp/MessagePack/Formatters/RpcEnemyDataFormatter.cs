namespace MessagePack.Formatters
{
	public sealed class RpcEnemyDataFormatter : IMessagePackFormatter<RpcEnemyData>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcEnemyData value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcEnemyData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
