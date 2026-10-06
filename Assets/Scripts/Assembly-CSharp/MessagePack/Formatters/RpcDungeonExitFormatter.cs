namespace MessagePack.Formatters
{
	public sealed class RpcDungeonExitFormatter : IMessagePackFormatter<RpcDungeonExit>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcDungeonExit value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcDungeonExit Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
