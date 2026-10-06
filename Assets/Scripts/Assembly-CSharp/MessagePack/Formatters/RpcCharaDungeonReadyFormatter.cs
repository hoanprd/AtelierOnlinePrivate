namespace MessagePack.Formatters
{
	public sealed class RpcCharaDungeonReadyFormatter : IMessagePackFormatter<RpcCharaDungeonReady>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcCharaDungeonReady value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcCharaDungeonReady Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
