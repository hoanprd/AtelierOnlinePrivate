namespace MessagePack.Formatters
{
	public sealed class RpcRequestDungeonDataFormatter : IMessagePackFormatter<RpcRequestDungeonData>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcRequestDungeonData value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcRequestDungeonData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
