namespace MessagePack.Formatters
{
	public sealed class RpcExqContinueFormatter : IMessagePackFormatter<RpcExqContinue>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcExqContinue value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcExqContinue Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
