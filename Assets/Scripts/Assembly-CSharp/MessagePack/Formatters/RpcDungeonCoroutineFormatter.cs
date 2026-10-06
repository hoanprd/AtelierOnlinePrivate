namespace MessagePack.Formatters
{
	public sealed class RpcDungeonCoroutineFormatter : IMessagePackFormatter<RpcDungeonCoroutine>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcDungeonCoroutine value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcDungeonCoroutine Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
