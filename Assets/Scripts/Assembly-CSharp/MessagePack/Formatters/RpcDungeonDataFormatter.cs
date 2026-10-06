namespace MessagePack.Formatters
{
	public sealed class RpcDungeonDataFormatter : IMessagePackFormatter<RpcDungeonData>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcDungeonData value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcDungeonData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
