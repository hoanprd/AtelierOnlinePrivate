namespace MessagePack.Formatters
{
	public sealed class RpcUpdateAbnormalStateFormatter : IMessagePackFormatter<RpcUpdateAbnormalState>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcUpdateAbnormalState value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcUpdateAbnormalState Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
