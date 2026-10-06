namespace MessagePack.Formatters
{
	public sealed class RpcGimmickExecFormatter : IMessagePackFormatter<RpcGimmickExec>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcGimmickExec value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcGimmickExec Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
