namespace MessagePack.Formatters
{
	public sealed class RpcExqQuestClearFormatter : IMessagePackFormatter<RpcExqQuestClear>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcExqQuestClear value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcExqQuestClear Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
